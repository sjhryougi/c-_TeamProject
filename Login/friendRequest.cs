using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class friendRequest : Form
    {

        //서버 연결을 위한 설정
        MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");
        string myId;
        public friendRequest(string Data)
        {
            InitializeComponent();
            connection.Open();

            myId = Data;
            RefreshListBox();
        }

        private void friendList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //수락시 isfriend에서 데이터 제거하고 friend에서 데이터 추가
        private void btnAccept_Click(object sender, EventArgs e)
        {
            string friendId = friendList.SelectedItem.ToString(); //선택한 사람의 id를 변수에 저장

            //is friend에서 데이터를 제거하기 위한 쿼리문 실행
            string deleteFriendRequest = string.Format("DELETE FROM isfriend WHERE sender = '{0}' and receiver = '{1}';",friendId ,myId);
            MySqlCommand command = new MySqlCommand(deleteFriendRequest, connection);
            command.ExecuteNonQuery();

            //상대방도 친구 추가를 보냈을 수도 있기에 이를 위한 쿼리문 
            //해당 쿼리문은 상대가 친구 추가를 보내지 않은 경우 오류가 발생할 수 있기에 예외처리문에 넣음
            try {
                deleteFriendRequest = string.Format("DELETE FROM isfriend WHERE sender = '{0}' and receiver = '{1}';",  myId, friendId);
                command = new MySqlCommand(deleteFriendRequest, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex) { };

            //friend에 데이터를 추가하기 위한 쿼리문 추가
            string insertFriend = string.Format("INSERT INTO friend (my_id, friend_id) VALUES ('{0}', '{1}');", myId, friendId);
            command = new MySqlCommand(insertFriend, connection);
            command.ExecuteNonQuery();

            //친구를 추가할 때 my_id인 부분을 나와 친구 둘다 추가해야 상대방이 친구가 됨을 알수 있다.
            insertFriend = string.Format("INSERT INTO friend (my_id, friend_id) VALUES ('{0}', '{1}');",  friendId, myId);
            command = new MySqlCommand(insertFriend, connection);
            command.ExecuteNonQuery();

            RefreshListBox();
        }



        //거절시 isfriend에서 데이터 제거
        private void btnReject_Click(object sender, EventArgs e)
        {
            string friendId = friendList.SelectedItem.ToString(); //선택한 사람의 id를 변수에 저장

            //is friend에서 데이터를 제거하기 위한 쿼리문 실행
            string deleteFriendRequest = string.Format("DELETE FROM isfriend WHERE sender = '{0}' and receiver = '{1}';", friendId, myId);
            MySqlCommand command = new MySqlCommand(deleteFriendRequest, connection);
            command.ExecuteNonQuery();

            RefreshListBox();
        }

        //listbox를 갱신해주기 위한 함수
        private void RefreshListBox()
        {
            
            friendList.Items.Clear(); //기존 listbox의 아이템 초기화

            //친구 요청을 보낸 사람을 찾기 위한 쿼리문
            string getFriendRequest = string.Format("SELECT * FROM isfriend WHERE receiver = '{0}'", myId);
            MySqlCommand command = new MySqlCommand(getFriendRequest, connection);
            MySqlDataReader todoRefresh = command.ExecuteReader();


            while (todoRefresh.Read())
            {
                //친구 요청을 보낸 사람의 id를 리스트 박스에 넣는다.
                friendList.Items.Add(todoRefresh["sender"].ToString());

            }
            todoRefresh.Close();
         
        }

        //폼 종료시 연결 해제
        private void friendRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
