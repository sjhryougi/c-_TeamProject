using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Todo1;

namespace ChattingProgram
{
    public partial class chat : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");

        string myID;
        public string friendID;

        Timer timer = new Timer();

        public chat(String Data)
        {
            InitializeComponent();

            connection.Open();
            myID = Data;
            
            timer.Interval = 500;
        }
        public void Send()
        {
            if(txtSend.Text != "")
            {
                string sendMessage = txtSend.Text;
                string sendTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // 메시지 전송
                timer.Stop();
                string insertMessage = string.Format("INSERT INTO chat (sender_id, receiver_id, content, time) VALUES ('{0}', '{1}', '{2}', '{3}');", myID, friendID, sendMessage, sendTime);
                MySqlCommand command = new MySqlCommand(insertMessage, connection);
                command.ExecuteNonQuery();
                
                txtSend.Clear();
                timer.Start();
                chatRefresh();
            }
        }

        /*private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }*/

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 친구 목록 불러오기
            LoadFriendsFromServer();
        }

        private void LoadFriendsFromServer()
        {
            // 서버에서 친구 목록을 가져오는 코드 작성
            // 가져온 친구 목록을 lstFriend에 추가
            
            string getFriendList = string.Format("SELECT * FROM friend WHERE my_id = '{0}'", myID);
            MySqlCommand command = new MySqlCommand(getFriendList, connection);
            MySqlDataReader todoRefresh = command.ExecuteReader();

            while (todoRefresh.Read())
            {
                //친구의 id를 리스트 박스에 넣기
                lstFriend.Items.Add(todoRefresh["friend_id"].ToString());

            }
            todoRefresh.Close();
        }

        private void Clear()
        {
            txtAll.Clear();
        }

        private void lstFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 친구 목록에서 선택할 경우
            if (lstFriend.SelectedItems.Count != 0)
            {
                Clear();
                chatRefresh();
                timeRefresh();
            }
        }

        private void timeRefresh()
        {
            // 0.5초마다 갱신
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            chatRefresh();
        }

        private void chatRefresh()
        {
            // 채팅창 갱신
            friendID = lstFriend.Items[lstFriend.FocusedItem.Index].SubItems[0].Text.ToString();
            // 채팅 로그 가져오기
            string getChatList = string.Format("SELECT * FROM chat WHERE (sender_id = '{0}' and receiver_id = '{1}') or (sender_id = '{1}' and receiver_id = '{0}') ORDER BY time ASC;", myID, friendID);
            MySqlCommand command = new MySqlCommand(getChatList, connection);
            MySqlDataReader chatReader = command.ExecuteReader();

            while (chatReader.Read())
            {

                if (!txtAll.Text.Contains(chatReader["time"].ToString()))
                {
                    if (chatReader["sender_id"].ToString() == myID)
                    {
                        txtAll.AppendText(myID + ">>" + chatReader["content"].ToString() + "\n" + chatReader["time"].ToString() + "\n");
                    }
                    else
                    {
                        txtAll.AppendText(friendID + ">>" + chatReader["content"].ToString() + "\n" + chatReader["time"].ToString() + "\n");
                    }
                }
            }
            chatReader.Close();
        }

        private void chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
            timer.Stop();
        }
    }
}
