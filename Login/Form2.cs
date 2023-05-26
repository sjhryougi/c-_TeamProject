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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=account;Uid=root;Pwd=000000000000;");
                connection.Open();

                string insertQuery = "INSERT INTO todolist_account (id, password) VALUES ('" + txtbox_id.Text + "', '" + txtbox_pwd.Text + "');";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    connection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("비정상적인 접근입니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
