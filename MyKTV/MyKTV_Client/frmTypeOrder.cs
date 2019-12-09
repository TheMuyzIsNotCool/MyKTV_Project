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
    public partial class frmTypeOrder : Form
    {
        public frmTypeOrder()
        {
            InitializeComponent();
        }

        public int songTypeID;
        public string SongTypeName;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.songTypeID = 2009;
            this.SongTypeName = "热门歌曲";
            frmTypeSongList ftsl = new frmTypeSongList();
            ftsl.lbTitle.Text = SongTypeName;
            ftsl.songTypeID = songTypeID;
            ftsl.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.songTypeID = 2003;
            this.SongTypeName = "影视金曲";
            frmTypeSongList ftsl = new frmTypeSongList();
            ftsl.lbTitle.Text = SongTypeName;
            ftsl.songTypeID = songTypeID;
            ftsl.ShowDialog();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.songTypeID = 2004;
            this.SongTypeName = "游戏动漫";
            frmTypeSongList ftsl = new frmTypeSongList();
            ftsl.lbTitle.Text = SongTypeName;
            ftsl.songTypeID = songTypeID;
            ftsl.ShowDialog();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.songTypeID = 2005;
            this.SongTypeName = "京剧戏曲";
            frmTypeSongList ftsl = new frmTypeSongList();
            ftsl.lbTitle.Text = SongTypeName;
            ftsl.songTypeID = songTypeID;
            ftsl.ShowDialog();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.songTypeID = 2006;
            this.SongTypeName = "儿歌";
            frmTypeSongList ftsl = new frmTypeSongList();
            ftsl.lbTitle.Text = SongTypeName;
            ftsl.songTypeID = songTypeID;
            ftsl.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong(); 
        }
    }
}
