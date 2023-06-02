using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChattingProgram
{
    public partial class chat : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");

        string myID;
        public string friendID;

        public chat(String Data)
        {
            InitializeComponent();

            connection.Open();
            myID = Data;
        }
        public void Send()
        {
            if(this.txtSend.Text != "")
            {
                string sendMessage = txtSend.Text;
                string sendTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // 메시지 전송
                try
                {
                    string insertMessage = string.Format("INSERT INTO chat (sender, reciver, content, TIME) VALUES ('{0}', '{1}', '{2}', '{3}');", myID, friendID, sendMessage, sendTime);
                    MySqlCommand command = new MySqlCommand(insertMessage, connection);
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("메시지가 입력되지 않았습니다.");
                }

                txtSend.Clear();
            }
        }

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
            connection.Close();
        }

        private void lstFriend_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Clear();

            friendID = lstFriend.Items.ToString();
            //채팅 로그 가져오기
            string getChatList = string.Format("SELECT * FROM chat WHERE sender = '{0}' or sender = '{1}' ORDERD BY TIME ASC;", myID, myID);
            MySqlCommand command = new MySqlCommand(getChatList, connection);
            MySqlDataReader chatReader = command.ExecuteReader();

            while (chatReader.Read())
            {
                if (chatReader["sender"].ToString() == myID)
                {
                    txtAll.AppendText(myID + ">>" + chatReader["content"].ToString() + "\n" + chatReader["TIME"].ToString() + "\n");
                }
                else
                {
                    txtAll.AppendText(friendID + ">>" + chatReader["content"].ToString() + "\n" + chatReader["TIME"].ToString() + "\n");
                }
            }
        }

        private void Clear()
        {
            txtAll.Clear();
        }
    }
}
