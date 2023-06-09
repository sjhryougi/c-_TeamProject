﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChattingProgram;
using Login;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace Todo1
{
    public partial class todo : Form
    {
        //자신의 id와 현재 선택한 사람의 id를 전역변수로 지정
        string myId;
        public string selectedId;

        //서버 연결을 위한 설정
        MySqlConnection connection = new MySqlConnection("Server = 34.64.76.194;Database=todolist;Uid=root;Pwd=12345;");

        public todo(string Data)
        {
            InitializeComponent();
            connection.Open(); //서버 연결

            dateTimePicker.Value = DateTime.Today; //캘린더의 날짜를 당일로 변경
            myId = Data; //signIn에서 넘긴 id를 저장
            selectedId = myId; //초기에 선택한 id는 자기 자신이다.
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
            if (selectedId == myId)
            {
                string todo = todoTextBox.Text;    //추가할 문자열을 todo에 저장

                //추가할 문자열이 공백인지 확인
                if (!string.IsNullOrEmpty(todo))
                {
                    string selectedDate = dateTimePicker.Value.Date.ToString("yyyy-MM-dd");

                    //입력할 때 중복이거나 텍스트의 길이가 너무 길면 db에 문제가 발생하기에 이를 막기 위한 예외처리문
                    try
                    {
                        //table에 값을 추가하기 위한 코드
                        //string insertList = "INSERT INTO todo (my_uid, date, text, check) VALUES ('" + myUid + "','" + selectedDate + "', '" + todo + "', '" +  0 +"');";
                        string insertList = string.Format("INSERT INTO todo (id, date, text, checkTodo) VALUES ('{0}', '{1}', '{2}', '{3}');", myId, selectedDate, todo, 0);
                        MySqlCommand command = new MySqlCommand(insertList, connection);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("중복되는 텍스트이거나 텍스트의 길이가 너무 깁니다.");
                    }

                    RefreshToDoList();
                    todoTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("다른 사람의 todo list를 수정할 수 없습니다!");
                todoTextBox.Clear();
            }

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            //본인의 todolist의 데이터만 삭제해야하기에 이를 위한 확인 절차
            if (selectedId == myId)
            {
                    //선택한 날짜와 아이템을 변수에 저장
                    string selectedDate = dateTimePicker.Value.Date.ToString("yyyy-MM-dd");
                    string selectedText = todoListBox.SelectedItem.ToString();

                    //선택한 값을 삭제하기 위한 쿼리문
                    string deleteList = string.Format("DELETE FROM todo WHERE id = '{0}' and date = '{1}'and text = '{2}';", myId, selectedDate, selectedText);
                    MySqlCommand command = new MySqlCommand(deleteList, connection);
                    command.ExecuteNonQuery();

                    RefreshToDoList();

            }
            else
            {
                MessageBox.Show("다른 사람의 todo list를 수정할 수 없습니다!");
            }
        }

        //선택한 날짜와 선택한 사람의 todolist를 출력하는 함수
        private void RefreshToDoList()
        {

            todoListBox.Items.Clear();
            string selectedDate = dateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            //db에서 선택한 날짜와 id에 맞는 데이터를 가져오기 위한 쿼리문 (
            string getTodoList = string.Format("SELECT text, checkTodo FROM todo WHERE id = '{0}' and date = '{1}'", selectedId, selectedDate);
            MySqlCommand command = new MySqlCommand(getTodoList, connection);
            MySqlDataReader todoRefresh = command.ExecuteReader();


            while (todoRefresh.Read())
            {
               //출력할 텍스트가 체크된것이면 체크 모양을 붙여서 출력하고 아니면 그냥 출력
                if (todoRefresh["checkTodo"].ToString() == "1") {
                    todoListBox.Items.Add("✔" + todoRefresh["text"].ToString());
                }
                else {
                    todoListBox.Items.Add(todoRefresh["text"].ToString());
                }               
            }            
            todoRefresh.Close();

            IdLabel.Text = "Todo List id : " + selectedId; //선택된 id로 출력

        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            //본인의 todolist의 데이터만 체크해야하기 때문에 이를 위한 확인 절차
            if (selectedId == myId)
            {
                //선택한 날짜와 아이템을 변수에 저장
                string selectedDate = dateTimePicker.Value.Date.ToString("yyyy-MM-dd");
                string selectedText = todoListBox.SelectedItem.ToString().Replace("✔", ""); //체크가 되어있는 텍스트가 존재할 수 있기에 이를 제거해야 한다.

                //선택한 값이 check 상태인지 값을 얻기 위한 쿼리문
                string findQuery = string.Format("SELECT checkTodo FROM todo WHERE id = '{0}' and date = '{1}'and text = '{2}';", myId, selectedDate, selectedText);
                MySqlCommand command = new MySqlCommand(findQuery, connection);
                MySqlDataReader todoReader = command.ExecuteReader();

                string updateQuery = ""; // checkTodo를 수정하기 위한 쿼리문
                todoReader.Read();

                //만약 체크 상태인 경우 체크를 해제하고 체크 상태가 아니면 체크한다.
                if (todoReader["checkTodo"].ToString() == "1")
                {
                    updateQuery = string.Format("UPDATE todo SET checkTodo = '0' WHERE id = '{0}' and date = '{1}'and text = '{2}';", myId, selectedDate, selectedText);
                }
                else
                {
                    updateQuery = string.Format("UPDATE todo SET checkTodo = '1' WHERE id = '{0}' and date = '{1}'and text = '{2}';", myId, selectedDate, selectedText);
                }
                todoReader.Close();

                //쿼리문 실행
                command = new MySqlCommand(updateQuery, connection);
                command.ExecuteNonQuery();


                RefreshToDoList();
            }
            else
            {
                MessageBox.Show("다른 사람의 todo list를 수정할 수 없습니다!");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //선택할 ud를 내 id로 바꾸는 버튼
        private void meButton_Click(object sender, EventArgs e)
        {
            selectedId = myId;
            RefreshToDoList();
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            chat chatForm = new chat(myId);
            chatForm.Owner = this;
            chatForm.ShowDialog();
        }


        private void todoListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            //친구 추가 창을 자식 폼으로 호출
            addFriend addFirendForm = new addFriend(myId);
            addFirendForm.Owner = this;
            addFirendForm.ShowDialog();
        }

        private void btnRequestComfirm_Click(object sender, EventArgs e)
        {
            //요청 확인 창을 자식 폼으로 호출
            friendRequest friendRequestForm = new friendRequest(myId);
            friendRequestForm.Owner = this;
            friendRequestForm.ShowDialog();
        }

        //폼 종료시 연결 해제
        private void todo_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            selectFriend selectFriendForm = new selectFriend(myId);
            selectFriendForm.Owner = this;
            //자식 폼으로부터 선택한 친구의 id 받는다. 이때 강제 종료된 경우를 제외하기 위해 if 문은 사용함
            if(selectFriendForm.ShowDialog() == DialogResult.OK)
            {
                RefreshToDoList();
            }
        }
    }

}

