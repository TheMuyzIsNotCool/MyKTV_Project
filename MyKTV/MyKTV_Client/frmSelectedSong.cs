using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV_Tools;

namespace MyKTV_Client
{
    public partial class frmSelectedSong : Form
    {
        public frmSelectedSong()
        {
            InitializeComponent();
        }


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

        private void frmSelectedSong_Load(object sender, EventArgs e)
        {
            showsong();
        }

        public void showsong()
        {
            //循环查询已点数组中是否有歌曲
            for (int i = 0; i < frmMain.fp.song.Length; i++)
            {
                Sound s = frmMain.fp.song[i];
                if (s != null && s.SongState != 2 )
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = s.SongName;
                    item.SubItems.Add(s.SingerName);
                    this.lvShow.Items.Add(item);
                }

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


    }
}
