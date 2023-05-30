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
using Todo1;

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
                //Database = 설정한 스키마 이름 uid = db 아이디 pwd = db 비밀번호
                MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");
                connection.Open();
                
                //로그인 상태 변수 선언, 비로그인 상태는 0
                int login_status = 0;
                int uid = 0;

                string loginid = txtbox_id.Text;
                string loginpwd = txtbox_pwd.Text;

                //mysql에 전송할 명령어 입력, 전송될 명령어는 ""사이의 값
                //string selectQuery = "SELECT * FROM account WHERE id = \'" + loginid + "\' ";
                string selectQuery = string.Format("SELECT * FROM account WHERE id = '{0}'",loginid);

                //MySqlCommand는 mysql로 명령어를 전송하기 위한 클래스
                //mysql에 selectQuery 값을 보내고 connection 값을 보내 연결 시도
                //위 정보를 Selectcommand에 저장
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);

                //MySqlDataReader은 입력 값을 받기 위함
                //excutereader 객체를 통해 입력 값을 받고 해당 정보를 userAccount에 저장
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                //userAccount에서 read 반복 => read마다 한 행씩 확인
                while (userAccount.Read())
                {
                    //아이디와 비번의 값이 일치하면 변수 상태를 1로 변경
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["password"])
                    {
                        login_status = 1;
                        uid = (int)userAccount["uid"];
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");

                    //로그인한 계정의 uid로 todo를 자식 폼으로 호출
                    todo todoForm = new todo(uid);
                    todoForm.Owner = this;
                    todoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 잘못 입력하셨거나 등록되지 않은 회원 입니다.");
                    txtbox_id.Clear(); //두 텍스트 박스 초기화
                    txtbox_pwd.Clear(); 
                }
            }
            catch (Exception ex)
            {
                //예외처리
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