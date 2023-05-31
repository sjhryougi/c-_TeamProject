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
            myId = Data;
        }

        private void friendList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }

        //listbox를 갱신해주기 위한 함수
        private void RefreshListBox()
        {
            /*
            friendList.Items.Clear(); //기존 listbox의 아이템 초기화

            //친구 요청을 보낸 사람을 찾기 위한 쿼리문
            string getFriendRequest = string.Format("SELECT text, checkTodo      FROM todo WHERE my_uid = '{0}' and date = '{1}'", selectedUid, selectedDate);
            MySqlCommand command = new MySqlCommand(getTodoList, connection);
            MySqlDataReader todoRefresh = command.ExecuteReader();


            while (todoRefresh.Read())
            {
                //출력할 텍스트가 체크된것이면 체크 모양을 붙여서 출력하고 아니면 그냥 출력
                if (todoRefresh["checkTodo"].ToString() == "1")
                {
                    todoListBox.Items.Add("✔" + todoRefresh["text"].ToString());
                }
                else
                {
                    todoListBox.Items.Add(todoRefresh["text"].ToString());
                }
            }
            todoRefresh.Close();
         */
        }
    }
}
