using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo1
{
    public partial class todo : Form
    {
        private Dictionary<DateTime, List<string>> todoDictionary;
        int uid;

        public todo(int Data)
        {
            InitializeComponent();
            todoDictionary = new Dictionary<DateTime, List<string>>();
            dateTimePicker.Value = DateTime.Today;
            uid = Data;
        }


        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshToDoList();

        }


        private void todoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string todo = todoTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(todo))
            {
                DateTime selectedDate = dateTimePicker.Value.Date;
                if (todoDictionary.ContainsKey(selectedDate))
                {
                    todoDictionary[selectedDate].Add(todo);
                }
                else
                {
                    List<string> todoList = new List<string> { todo };
                    todoDictionary.Add(selectedDate, todoList);
                }

                RefreshToDoList();
                todoTextBox.Clear();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
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
            }
        }
        private void RefreshToDoList()
        {
            todoListBox.Items.Clear();
            DateTime selectedDate = dateTimePicker.Value.Date;
            if (todoDictionary.ContainsKey(selectedDate))
            {
                List<string> todoList = todoDictionary[selectedDate];
                foreach (string todo in todoList)
                {
                    todoListBox.Items.Add(todo);
                }
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value.Date;
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
            }
        
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

        private void friend1Button_Click(object sender, EventArgs e)
        {

        }

        private void friend2Button_Click(object sender, EventArgs e)
        {

        }
    }

}

