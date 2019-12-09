using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV_Server
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lbtips.Text = "管理员："+Helper.username+ "，天冷了，要注意保暖喔" ;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            frmRes fr = new frmRes();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSingerInfoEdit fsi = new frmSingerInfoEdit();
            fsi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSong fs = new frmSong();
            fs.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.Show();
        }
    }
}
