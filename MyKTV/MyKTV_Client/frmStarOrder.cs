using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV_Client
{
    public partial class frmStarOrder : Form
    {
        public frmStarOrder()
        {
            InitializeComponent();
        }

        public int singerTypeID;
        public string singerGender;


        private void pbReSay_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void pbMain_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }

        private void pbcn_Click(object sender, EventArgs e)
        {
            //大陆歌手数据库ID     1001
            this.singerTypeID = 1001;
            this.panSIngerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pnes_Click(object sender, EventArgs e)
        {
            //港台歌手数据库ID     1003
            this.singerTypeID = 1003;
            this.panSIngerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pbtw_Click(object sender, EventArgs e)
        {
            //欧美歌手数据库ID     1002
            this.singerTypeID = 1002;
            this.panSIngerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pbjp_Click(object sender, EventArgs e)
        {
            //日韩歌手数据库ID     1004
            this.singerTypeID = 1004;
            this.panSIngerType.Visible = false;
            this.panGender.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.singerGender = "男";
            //选择信息传递
            frmStarList fsl = new frmStarList();
            fsl.singerTypeID = this.singerTypeID;
            fsl.singerGender = this.singerGender;

            fsl.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.singerGender = "女";
            frmStarList fsl = new frmStarList();
            fsl.singerTypeID = this.singerTypeID;
            fsl.singerGender = this.singerGender;

            fsl.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.singerGender = "组合";
            frmStarList fsl = new frmStarList();
            fsl.singerTypeID = this.singerTypeID;
            fsl.singerGender = this.singerGender;

            fsl.ShowDialog();
            this.Close();
        }

        private void frmStarOrder_Load(object sender, EventArgs e)
        {
            this.panSIngerType.Visible = true;
            this.panGender.Visible = false;
        }
    }
}
