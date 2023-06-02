using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo1;

namespace Login
{
    public partial class selectFriend : Form
    {
        
        String myId;
        public selectFriend(String Data)
        {
            InitializeComponent();
            myId = Data;

            RefreshListBox();
        }

        private void selectListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //listbox를 갱신해주기 위한 함수
        private void RefreshListBox()
        {
            //서버 연결
            MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");
            connection.Open();


            //친구를 불러오기 위한 쿼리
            string getFriendList = string.Format("SELECT * FROM friend WHERE my_id = '{0}'", myId);
            MySqlCommand command = new MySqlCommand(getFriendList, connection);
            MySqlDataReader todoRefresh = command.ExecuteReader();


            while (todoRefresh.Read())
            {
                //친구의 id를 리스트 박스에 넣는다.
                selectListbox.Items.Add(todoRefresh["friend_id"].ToString());

            }
            todoRefresh.Close();
            connection.Close();

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            string friendID = selectListbox.SelectedItem.ToString();

            //부모폼(todo) 호출
            todo todoForm = (todo)Owner;
            todoForm.selectedId = friendID;
            this.Close();
        }
    }
}
