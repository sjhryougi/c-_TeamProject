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
            this.txtFriend.Location = new System.Drawing.Point(35, 68);
            this.txtFriend.Multiline = true;
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(359, 36);
            this.txtFriend.TabIndex = 0;
            this.txtFriend.WordWrap = false;
            this.txtFriend.TextChanged += new System.EventHandler(this.txtFriend_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(431, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 162);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFriend);
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