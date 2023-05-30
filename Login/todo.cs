using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Todo1
{
    public partial class todo : Form
    {
        //자신의 uid와 현재 선택한 사람의 uid를 전역변수로 지정
        int myUid;
        int selectedUid;

        //서버 연결을 위한 설정
        MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");

        public todo(int Data)
        {
            InitializeComponent();
            connection.Open(); //서버 연결

            dateTimePicker.Value = DateTime.Today; //캘린더의 날짜를 당일로 변경
            myUid = Data; //signIn에서 넘긴 uid값을 저장
            selectedUid = myUid; //초기에 선택한 uid는 자기 자신이다.
            RefreshToDoList(); //todolist 실행

        }


        // 캘린더로 날짜를 변경한 경우
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshToDoList();
        }


        private void todoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //본인의 todolist에만 데이터를 추가해야하기에 이를 위한 확인 절차
            if (selectedUid == myUid)
            {
                string todo = todoTextBox.Text;    //추가할 문자열을 todo에 저장

                //추가할 문자열이 공백인지 확인
                if (!string.IsNullOrEmpty(todo))
                {
                    string selectedDate = dateTimePicker.Value.Date.ToString("yyyy-MM-dd");


                    //table에 값을 추가하기 위한 코드
                    //string insertList = "INSERT INTO todo (my_uid, date, text, check) VALUES ('" + myUid + "','" + selectedDate + "', '" + todo + "', '" +  0 +"');";
                    string insertList = string.Format("INSERT INTO todo (my_uid, date, text, checkTodo) VALUES ('{0}', '{1}', '{2}', '{3}');", myUid, selectedDate, todo, 0);
                    MySqlCommand command = new MySqlCommand(insertList, connection);
                    command.ExecuteNonQuery();


                    RefreshToDoList();
                    todoTextBox.Clear();
                    // connection.Close();
                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {/*
            DateTime selectedDate = dateTimePicker.Value.Date;
            if (todoDictionary.ContainsKey(selectedDate))
            {
                List<string> todoList = todoDictionary[selectedDate];
                string selectedTodo = todoListBox.SelectedItem.ToString();
                todoList.Remove(selectedTodo);
                if (todoList.Count == 0)
                {
                    todoDictionary.Remove(selectedDate);
                }

                RefreshToDoList();
            }*/
        }
        private void RefreshToDoList()
        {

            todoListBox.Items.Clear();
            string selectedDate = dateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            //db에서 선택한 날짜와 uid에 맞는 데이터를 가져오기 위한 쿼리문
            string getTodoList = string.Format("SELECT text, checkTodo FROM todo WHERE my_uid = '{0}' and date = '{1}'", selectedUid, selectedDate);
            MySqlCommand command = new MySqlCommand(getTodoList, connection);
            MySqlDataReader todoReader = command.ExecuteReader();

            while (todoReader.Read())
            {
                todoListBox.Items.Add(todoReader["text"].ToString());
            }
            todoReader.Close();

        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            /*
            if (todoDictionary.ContainsKey(selectedDate))
            {
                List<string> todoList = todoDictionary[selectedDate];
                int selectedIndex = todoListBox.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < todoList.Count)
                {
                    string selectedTodo = todoList[selectedIndex];
                    if (selectedTodo.EndsWith(" [완료]"))
                    {
                        string uncompletedTodo = selectedTodo.Substring(0, selectedTodo.Length - 5);
                        todoList[selectedIndex] = uncompletedTodo;
                        todoListBox.Items[selectedIndex] = uncompletedTodo;
                    }
                    else
                    {
                        string completedTodo = selectedTodo + " [완료]";
                        todoList[selectedIndex] = completedTodo;
                        todoListBox.Items[selectedIndex] = completedTodo;
                    }
                }
            }*/

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void meButton_Click(object sender, EventArgs e)
        {

        }

        private void chatButton_Click(object sender, EventArgs e)
        {

        }

        //보고 싶은 todolist의 사람의 이름을 선택하기 위한 combobox
        private void cmbSelectName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

