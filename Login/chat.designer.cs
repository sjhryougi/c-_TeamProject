﻿namespace ChattingProgram
{
    partial class chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.txtAll = new System.Windows.Forms.RichTextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstFriend = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImage = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtAll
            // 
            this.txtAll.BackColor = System.Drawing.SystemColors.Window;
            this.txtAll.Location = new System.Drawing.Point(169, 37);
            this.txtAll.Name = "txtAll";
            this.txtAll.ReadOnly = true;
            this.txtAll.Size = new System.Drawing.Size(619, 360);
            this.txtAll.TabIndex = 0;
            this.txtAll.Text = "";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(169, 417);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(553, 21);
            this.txtSend.TabIndex = 1;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(729, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(59, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            // 
            // lstFriend
            // 
            this.lstFriend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstFriend.HideSelection = false;
            this.lstFriend.Location = new System.Drawing.Point(12, 37);
            this.lstFriend.MultiSelect = false;
            this.lstFriend.Name = "lstFriend";
            this.lstFriend.Size = new System.Drawing.Size(151, 360);
            this.lstFriend.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstFriend.TabIndex = 5;
            this.lstFriend.TileSize = new System.Drawing.Size(228, 50);
            this.lstFriend.UseCompatibleStateImageBehavior = false;
            this.lstFriend.View = System.Windows.Forms.View.SmallIcon;
            this.lstFriend.SelectedIndexChanged += new System.EventHandler(this.lstFriend_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 100;
            // 
            // btnImage
            // 
            this.btnImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImage.ImageIndex = 0;
            this.btnImage.ImageList = this.imageList2;
            this.btnImage.Location = new System.Drawing.Point(12, 415);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(151, 28);
            this.btnImage.TabIndex = 6;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "2.png");
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.lstFriend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtAll);
            this.Name = "chat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.chat_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAll;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lstFriend;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ImageList imageList2;
    }
}

