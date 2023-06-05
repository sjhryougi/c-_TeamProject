namespace Login
{
    partial class addFriend
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
            this.txtFriend = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFriend
            // 
            this.txtFriend.Location = new System.Drawing.Point(24, 45);
            this.txtFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFriend.Multiline = true;
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(252, 25);
            this.txtFriend.TabIndex = 0;
            this.txtFriend.WordWrap = false;
            this.txtFriend.TextChanged += new System.EventHandler(this.txtFriend_TextChanged);
            this.txtFriend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFriend_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 45);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 108);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFriend);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addFriend";
            this.Text = "친구 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFriend;
        private System.Windows.Forms.Button btnAdd;
    }
}