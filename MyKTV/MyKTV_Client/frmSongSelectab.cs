using MyKTV_Tools;
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
    public partial class frmSongSelectab : Form
    {
        public frmSongSelectab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 歌曲字数查询
        /// </summary>
        /// <param name="SongWorldConcent"></param>
        public void showsong(int SongWorldConcent)
        {
            lvShow.Items.Clear();
            //查询所有匹配的数字歌曲
            Sound[] songs = new Sound[50];
            //根据歌曲列表查询相应的内容
            string sqlStr = "select SongID,SongName,SingerName,Url from Song a, Singer b where a.SingerID = b.SingerID ";
            if (SongWorldConcent <= 6)
            {
                sqlStr += "and SongWordCount ="+ SongWorldConcent;
            }
            else
            {
                sqlStr += "and SongWordCount > 6";
            }
            DBHelper.GetReader(sqlStr);
            while (DBHelper.dr.Read())
            {
                Sound s = new Sound();
                s.SongID = (int)DBHelper.dr["SongID"];
                s.SongName = DBHelper.dr["SongName"].ToString();
                s.SingerName = DBHelper.dr["SingerName"].ToString();
                s.Url = DBHelper.dr["Url"].ToString();

                ListViewItem item = new ListViewItem(s.SongName);
                item.SubItems.Add(s.SingerName);
                lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }

        private void pbMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            frmMain.fp.NextSong();
        }

        private void pbReSay_Click(object sender, EventArgs e)
        {
            frmMain.fp.RelSong();
        }

        private void frmSongSelectab_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            showsong(1);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            showsong(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            showsong(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            showsong(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            showsong(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            showsong(6);
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count>0)
            {
                string SongName = this.lvShow.SelectedItems[0].Text;
                string sqlstr = "select b.SingerID,SongID,SongName,SingerName,Url from Song a, Singer b where a.SingerID = b.SingerID and SongName = '" + SongName+"'";
                DBHelper.GetReader(sqlstr);
                Sound s = null;
                if (DBHelper.dr.Read())
                {
                    s = new Sound();
                    s.SongID = (int)DBHelper.dr["SongID"];
                    s.SingerID = (int)DBHelper.dr["SingerID"];
                    s.SongName = DBHelper.dr["SongName"].ToString();
                    s.SingerName = DBHelper.dr["SingerName"].ToString();
                    s.Url = DBHelper.dr["Url"].ToString();

                    for (int i = 0; i < frmMain.fp.song.Length; i++)
                    {
                        if (frmMain.fp.song[i] == null)
                        {
                            frmMain.fp.song[i] = s;
                            break;
                        }
                    }
                    
                }
                DBHelper.dr.Close();
                DBHelper.conn.Close();
                string sqlstr1 = "Update Song set ClientCount = ClientCount +1 where SongID = " + s.SongID;
                DBHelper.getNonQuery(sqlstr);

            }
            DBHelper.dr.Close();
            
        }
    }
}
