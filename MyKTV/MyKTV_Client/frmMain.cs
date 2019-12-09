using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyKTV_Tools;

namespace MyKTV_Client
{
    public partial class frmMain : Form
    {
        //静态播放器界面，方便其他界面进行调用
        public static frmaxWMP fp = new frmaxWMP();
        //public static frmPlayer fp = new frmPlayer();



        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //加载文件夹资源地址
            Resources.InitResource();
            fp.Show();

        }

        private void pbReSay_Click(object sender, EventArgs e)
        {
            fp.RelSong();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            fp.NextSong();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fp.song[0]==null)
            {
                return;
            }


            this.lbPlay.Text = fp.song[fp.index].SongName + " - " + fp.song[fp.index].SingerName;

            if (fp.index == (fp.song.Length - 1) || fp.song[fp.index+1] == null)
            { 
                this.lbNext.Text = "未找到歌曲";
            }
            else
            {
                //string sqlStr1 = "select SingerName from Singer where SingerID=" + fp.song[fp.index + 1].SingerID;
                //string singerName1 = DBHelper.getScalar(sqlStr1).ToString();
                this.lbNext.Text = fp.song[fp.index + 1].SongName + " - " + fp.song[fp.index+1].SingerName;
            }


            //利用Timer，VLC控件播放状态，切歌方法实现播放完成切歌功能
            if (fp.VlcPlayerBase.Duration > 0 && (int)fp.VlcPlayerBase.GetPlayTime() == (int)fp.VlcPlayerBase.Duration)
            {
                fp.NextSong();
            }
        }

        private void pbSelected_Click(object sender, EventArgs e)
        {
            frmSelectedSong fss = new frmSelectedSong();
            fss.ShowDialog();

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMany_Click(object sender, EventArgs e)
        {
            frmSongSelectab fssab = new frmSongSelectab();
            fssab.ShowDialog();
        }

        private void pbAB_Click(object sender, EventArgs e)
        {
            frmSongABorder fsab = new frmSongABorder();
            fsab.ShowDialog();
        }

        private void pbTop_Click(object sender, EventArgs e)
        {
            frmTopOrder fto = new frmTopOrder();
            fto.ShowDialog();
        }

        private void pbSinger_Click(object sender, EventArgs e)
        {
            frmStarOrder fso = new frmStarOrder();
            fso.ShowDialog();
        }

        private void pbType_Click(object sender, EventArgs e)
        {
            frmTypeOrder fto = new frmTypeOrder();
            fto.ShowDialog();
        }
    }
}
