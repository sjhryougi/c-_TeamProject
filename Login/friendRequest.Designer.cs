namespace Login
{
    partial class friendRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.friendList = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // friendList
            // 
            this.friendList.FormattingEnabled = true;
            this.friendList.ItemHeight = 18;
            this.friendList.Location = new System.Drawing.Point(32, 29);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(436, 292);
            this.friendList.TabIndex = 0;
            this.friendList.SelectedIndexChanged += new System.EventHandler(this.friendList_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAccept.Location = new System.Drawing.Point(525, 29);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(155, 119);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "수락";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReject.Location = new System.Drawing.Point(525, 202);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(155, 119);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "거부";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // friendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 379);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.friendList);
            this.Name = "friendRequest";
            this.Text = "friendRequest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.friendRequest_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox friendList;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
    }
}