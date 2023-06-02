namespace Login
{
    partial class selectFriend
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
            this.selectListbox = new System.Windows.Forms.ListBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectListbox
            // 
            this.selectListbox.FormattingEnabled = true;
            this.selectListbox.ItemHeight = 18;
            this.selectListbox.Location = new System.Drawing.Point(25, 30);
            this.selectListbox.Name = "selectListbox";
            this.selectListbox.Size = new System.Drawing.Size(417, 364);
            this.selectListbox.TabIndex = 0;
            this.selectListbox.SelectedIndexChanged += new System.EventHandler(this.selectListbox_SelectedIndexChanged);
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnselect.Location = new System.Drawing.Point(466, 30);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(221, 110);
            this.btnselect.TabIndex = 1;
            this.btnselect.Text = "선택";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // selectFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 451);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.selectListbox);
            this.Name = "selectFriend";
            this.Text = "친구 선택";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox selectListbox;
        private System.Windows.Forms.Button btnselect;
    }
}