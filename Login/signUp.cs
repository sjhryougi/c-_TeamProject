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
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            try
            {
                //입력 값의 앞뒤에 공백이 있을 수 있기에 이를 처리
                string id = txtbox_id.Text.Trim();
                string pwd = txtbox_pwd.Text.Trim();

                //만약 아이디나 비번 중 한개라도 공백인 경우 리턴
                if (id == "" || pwd == "") {
                    MessageBox.Show("공백인 칸이 존재합니다.");
                    txtbox_id.Clear(); //두 텍스트 박스 초기화
                    txtbox_pwd.Clear();
                    return;
                }
                    

                //서버 연결
                MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");
                connection.Open();

                //중복된 아이디인지 확인하기 위한 변수
                // 0 -> 중복 아님(default) 1 -> 중복
                int isDuplicated = 0;

                //중복을 찾기 위한 쿼리문
                string searchDuplication = "SELECT * FROM account WHERE id = \'" + id + "\' ";
                MySqlCommand Selectcommand = new MySqlCommand(searchDuplication, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                //중복되는 id가 있는지 확인
                while (userAccount.Read()) {
                    if (id == (string)userAccount["id"])
                        isDuplicated = 1;
                }
                userAccount.Close();

                //중복되지 않은 id가 있으면 추가
                if (isDuplicated != 1)
                {
                    
                    //account table에 값을 추가하기 위한 코드
                    string insertQuery = "INSERT INTO account (id, password) VALUES ('" + id + "', '" + pwd + "');";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();
             
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    connection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("중복되는 아이디입니다.");
                    txtbox_id.Clear(); //두 텍스트 박스 초기화
                    txtbox_pwd.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
