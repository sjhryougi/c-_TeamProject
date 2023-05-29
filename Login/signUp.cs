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
                //서버 연결
                MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");
                connection.Open();

                //중복된 아이디인지 확인하기 위한 변수
                // 0 -> 중복 아님(default) 1 -> 중복
                int isDuplicated = 0;

                //중복을 찾기 위한 쿼리문
                string searchDuplication = "SELECT * FROM account WHERE id = \'" + txtbox_id.Text + "\' ";
                MySqlCommand Selectcommand = new MySqlCommand(searchDuplication, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                //중복되는 id가 있는지 확인
                while (userAccount.Read()) {
                    if (txtbox_id.Text == (string)userAccount["id"])
                        isDuplicated = 1;
                }
                userAccount.Close();

                //중복되지 않은 id가 있으면 추가
                if (isDuplicated != 1)
                {
                    //uid를 구하기 위한 코드
                    //db의 마지막 행을 구하는 쿼리문
                    string getUid = "SELECT * FROM account ORDER BY uid DESC LIMIT 1";
                    MySqlCommand getUidCommand = new MySqlCommand(getUid, connection);
                    MySqlDataReader getUidReader = getUidCommand.ExecuteReader();

                    //한번만 읽으면 되기 때문에 while 사용하지 않음
                    //uid를 구하고 1을 더하면 된다.
                    //맨 처음인 경우 행이 없을 수 있기 때문에 디폴트로 1을 설정하고 행이 있으면 수정하는 방식
                    getUidReader.Read();
                    int uid = 1;
                    if (getUidReader.HasRows)
                    {
                        uid = (int)getUidReader["uid"] + 1;
                    }
                    getUidReader.Close();


                    //account table에 값을 추가하기 위한 코드
                    string insertQuery = "INSERT INTO account (uid, id, password) VALUES ('" + uid + "','" + txtbox_id.Text + "', '" + txtbox_pwd.Text + "');";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.ExecuteNonQuery();
             
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    connection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("중복되는 아이디입니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
