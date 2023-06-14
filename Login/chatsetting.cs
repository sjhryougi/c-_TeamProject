using ChattingProgram;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class chatsetting : Form
    {
        public chatsetting()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ((chat)(this.Owner)).txtAll.Font = fontDialog1.Font;
            }
        }

        private void btnMyClr_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((chat)(this.Owner)).mynameColor = colorDialog1.Color;
            }
        }

        private void btnFrdClr_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((chat)(this.Owner)).myfriendColor = colorDialog1.Color;
            }
        }
    }
}
