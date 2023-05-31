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
    public partial class addFriend : Form
    {
        string myId;

        public addFriend(string data)
        {
            InitializeComponent();

            myId = data;
        }

        private void txtFriend_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string friendName = txtFriend.Text; //텍스트 박스에 적은 내용을 저장
            string friendId; //친구의 id를 저장할 변수

            //서버 연결을 위한 설정
            MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");
            connection.Open();

            //예외처리 해야하는 부분은 입력한 텍스트의 id를 가진 사람이 존재하는지 그게 자기 자신이 아니어야 하고
            // 해당 인물이 이미 친구인지 이미 친구 추가를 했는지 3경우를 확인해야 한다.
            //먼저 입력한 텍스트의 id를 가진 사람이 존재하는지 확인
            string findQuery = string.Format("SELECT * FROM account WHERE id = '{0}'",friendName);
            MySqlCommand command = new MySqlCommand(findQuery, connection);
            MySqlDataReader accountReader = command.ExecuteReader();
            
            //해당 id가 존재하면 그 id가 자기 자신인지 확인
            if(accountReader.HasRows) {
                accountReader.Read();
                //id가 자기 자신이 아니라면 이미 친구인지 확인
                if ((string)accountReader["id"] != myId) {
                    friendId = (string)accountReader["Id"]; //친구의 uid 저장
                    accountReader.Close();

                    //이미 친구인지 확인하기 위한 쿼리문
                    findQuery = string.Format("SELECT * FROM friend WHERE my_id = '{0}' and friend_id = '{1}'", myId,friendId);
                    command = new MySqlCommand(findQuery, connection);
                    accountReader = command.ExecuteReader();
                    
                    //친구가 아니면 이미 친구 신청을 보냈는지 확인
                    if (!accountReader.HasRows) {
                        accountReader.Close();
                        findQuery = string.Format("SELECT * FROM isfriend WHERE sender = '{0}' and receiver = '{1}'", myId, friendId);
                        command = new MySqlCommand(findQuery, connection);
                        accountReader = command.ExecuteReader();

                        //모든 경우가 아닌 경우 친구 추가를 보낸다.
                        if (!accountReader.HasRows) {
                            accountReader.Close();
                            string insertQuery = string.Format("INSERT INTO isfriend (sender, receiver) VALUES ('{0}', '{1}');", myId, friendId);
                            command = new MySqlCommand(insertQuery, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("친구 추가를 보냈습니다.");
                            txtFriend.Clear();
                        } else
                        {
                            MessageBox.Show("이미 친구 신청을 보낸 상태입니다");
                            txtFriend.Clear();
                            accountReader.Close();
                        }

                    } else
                    {
                        MessageBox.Show("이미 친구인 사람입니다");
                        txtFriend.Clear();
                        accountReader.Close();
                    }
                }   
                else
                {
                    MessageBox.Show("자기 자신에게 친구 신청을 할 수 없습니다.");
                    txtFriend.Clear();
                    accountReader.Close();
                }
            }
            else
            {
                MessageBox.Show("존재하지 않는 id입니다");
                txtFriend.Clear();
                accountReader.Close();
            }
            connection.Close();
        }
    }
}
