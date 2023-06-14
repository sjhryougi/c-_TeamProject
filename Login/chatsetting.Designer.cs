namespace Login
{
    partial class chatsetting
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
            this.lbFont = new System.Windows.Forms.Label();
            this.lbMyClr = new System.Windows.Forms.Label();
            this.lbFrdClr = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnMyClr = new System.Windows.Forms.Button();
            this.btnFrdClr = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Location = new System.Drawing.Point(41, 24);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(29, 12);
            this.lbFont.TabIndex = 0;
            this.lbFont.Text = "글꼴";
            // 
            // lbMyClr
            // 
            this.lbMyClr.AutoSize = true;
            this.lbMyClr.Location = new System.Drawing.Point(33, 60);
            this.lbMyClr.Name = "lbMyClr";
            this.lbMyClr.Size = new System.Drawing.Size(45, 12);
            this.lbMyClr.TabIndex = 1;
            this.lbMyClr.Text = "내 이름";
            // 
            // lbFrdClr
            // 
            this.lbFrdClr.AutoSize = true;
            this.lbFrdClr.Location = new System.Drawing.Point(28, 99);
            this.lbFrdClr.Name = "lbFrdClr";
            this.lbFrdClr.Size = new System.Drawing.Size(57, 12);
            this.lbFrdClr.TabIndex = 2;
            this.lbFrdClr.Text = "친구 이름";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(139, 19);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "변경";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnMyClr
            // 
            this.btnMyClr.Location = new System.Drawing.Point(139, 55);
            this.btnMyClr.Name = "btnMyClr";
            this.btnMyClr.Size = new System.Drawing.Size(75, 23);
            this.btnMyClr.TabIndex = 4;
            this.btnMyClr.Text = "변경";
            this.btnMyClr.UseVisualStyleBackColor = true;
            this.btnMyClr.Click += new System.EventHandler(this.btnMyClr_Click);
            // 
            // btnFrdClr
            // 
            this.btnFrdClr.Location = new System.Drawing.Point(139, 94);
            this.btnFrdClr.Name = "btnFrdClr";
            this.btnFrdClr.Size = new System.Drawing.Size(75, 23);
            this.btnFrdClr.TabIndex = 5;
            this.btnFrdClr.Text = "변경";
            this.btnFrdClr.UseVisualStyleBackColor = true;
            this.btnFrdClr.Click += new System.EventHandler(this.btnFrdClr_Click);
            // 
            // chatsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 135);
            this.Controls.Add(this.btnFrdClr);
            this.Controls.Add(this.btnMyClr);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.lbFrdClr);
            this.Controls.Add(this.lbMyClr);
            this.Controls.Add(this.lbFont);
            this.Name = "chatsetting";
            this.Text = "chatsetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.Label lbMyClr;
        private System.Windows.Forms.Label lbFrdClr;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnMyClr;
        private System.Windows.Forms.Button btnFrdClr;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}