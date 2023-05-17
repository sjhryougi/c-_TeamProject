namespace ChattingProgram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1", "1.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3", 2);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImage = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(169, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(619, 360);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(729, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(59, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.옵션OToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 옵션OToolStripMenuItem
            // 
            this.옵션OToolStripMenuItem.Name = "옵션OToolStripMenuItem";
            this.옵션OToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.옵션OToolStripMenuItem.Text = "옵션(O)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(12, 37);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(151, 360);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.TileSize = new System.Drawing.Size(228, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
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
            this.btnImage.Location = new System.Drawing.Point(12, 403);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(44, 40);
            this.btnImage.TabIndex = 6;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "2.png");
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(119, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
    }
}

