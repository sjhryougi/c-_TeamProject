﻿namespace Todo1
{
    partial class todo
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.todoTextBox = new System.Windows.Forms.TextBox();
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.meButton = new System.Windows.Forms.Button();
            this.chatButton = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.btnRequestComfirm = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addButton.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addButton.Location = new System.Drawing.Point(291, 313);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteButton.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteButton.Location = new System.Drawing.Point(497, 313);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 50);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.completeButton.Location = new System.Drawing.Point(705, 264);
            this.completeButton.Margin = new System.Windows.Forms.Padding(2);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 35);
            this.completeButton.TabIndex = 2;
            this.completeButton.Text = "체크";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 50);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(263, 35);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // todoTextBox
            // 
            this.todoTextBox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.todoTextBox.Location = new System.Drawing.Point(291, 264);
            this.todoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.todoTextBox.Name = "todoTextBox";
            this.todoTextBox.Size = new System.Drawing.Size(406, 35);
            this.todoTextBox.TabIndex = 5;
            this.todoTextBox.TextChanged += new System.EventHandler(this.todoTextBox_TextChanged);
            // 
            // todoListBox
            // 
            this.todoListBox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 28;
            this.todoListBox.Location = new System.Drawing.Point(291, 50);
            this.todoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(406, 200);
            this.todoListBox.TabIndex = 6;
            this.todoListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.todoListBox_DrawItem);
            this.todoListBox.SelectedIndexChanged += new System.EventHandler(this.todoListBox_SelectedIndexChanged);
            // 
            // meButton
            // 
            this.meButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.meButton.Location = new System.Drawing.Point(12, 8);
            this.meButton.Name = "meButton";
            this.meButton.Size = new System.Drawing.Size(117, 33);
            this.meButton.TabIndex = 7;
            this.meButton.Text = "ME";
            this.meButton.UseVisualStyleBackColor = true;
            this.meButton.Click += new System.EventHandler(this.meButton_Click);
            // 
            // chatButton
            // 
            this.chatButton.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chatButton.Location = new System.Drawing.Point(12, 313);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(239, 50);
            this.chatButton.TabIndex = 10;
            this.chatButton.Text = "채팅하기";
            this.chatButton.UseVisualStyleBackColor = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddFriend.Location = new System.Drawing.Point(12, 264);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(117, 43);
            this.btnAddFriend.TabIndex = 12;
            this.btnAddFriend.Text = "친구 추가";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // btnRequestComfirm
            // 
            this.btnRequestComfirm.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRequestComfirm.Location = new System.Drawing.Point(135, 264);
            this.btnRequestComfirm.Name = "btnRequestComfirm";
            this.btnRequestComfirm.Size = new System.Drawing.Size(117, 43);
            this.btnRequestComfirm.TabIndex = 13;
            this.btnRequestComfirm.Text = "요청 확인";
            this.btnRequestComfirm.UseVisualStyleBackColor = true;
            this.btnRequestComfirm.Click += new System.EventHandler(this.btnRequestComfirm_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btn.Location = new System.Drawing.Point(135, 8);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(139, 33);
            this.btn.TabIndex = 14;
            this.btn.Text = "친구 선택";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IdLabel.Location = new System.Drawing.Point(297, 8);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(44, 28);
            this.IdLabel.TabIndex = 16;
            this.IdLabel.Text = "----";
            // 
            // todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 389);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnRequestComfirm);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.meButton);
            this.Controls.Add(this.todoListBox);
            this.Controls.Add(this.todoTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "todo";
            this.Text = "TodoList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.todo_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox todoTextBox;
        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Button meButton;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.Button btnRequestComfirm;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label IdLabel;
    }
}

