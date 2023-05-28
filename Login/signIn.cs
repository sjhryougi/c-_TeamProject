using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=account;Uid=root;Pwd=000000000000;");
                connection.Open();
                //Database = 설정한 스키마 이름 uid = db 아이디 pwd = db 비밀번호
                int login_status = 0;

                string loginid = txtbox_id.Text;
                string loginpwd = txtbox_pwd.Text;

                string selectQuery = "SELECT * FROM todolist_account WHERE id = \'" + loginid + "\' ";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["password"])
                    {
                        login_status = 1;
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");
                }
                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 잘못 입력하셨거나 등록되지 않은 회원 입니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            signUp showform2 = new signUp();
            showform2.ShowDialog();
        }
    }
}