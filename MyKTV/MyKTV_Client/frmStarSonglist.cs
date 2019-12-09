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
    public partial class frmStarSonglist : Form
    {
        public string Sname;

        public frmStarSonglist()
        {
            InitializeComponent();
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

        private void frmStarSonglist_Load(object sender, EventArgs e)
        {
            string sqlstr = "select SongID,SongName,SingerName,url,a.SingerID,ClientCount from Song a,Singer b where a.SingerID=b.SingerID and SingerName='"+this.lbTitle.Text+"'";
            DBHelper.GetReader(sqlstr);
            while (DBHelper.dr.Read())
            {
                Sound s = new Sound();
                s.SongID = (int)DBHelper.dr["SongID"];
                s.SingerID = (int)DBHelper.dr["SingerID"];
                s.SongName = DBHelper.dr["SongName"].ToString();
                s.SingerName = DBHelper.dr["SingerName"].ToString();
                s.Url = DBHelper.dr["Url"].ToString();

                ListViewItem item = new ListViewItem(s.SongName);
                item.SubItems.Add(s.SingerName);
                this.lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count > 0 )
            {
                string songName = this.lvShow.SelectedItems[0].Text;
                string sqlstr = "select SongID,SongName,SingerName,url,a.SingerID from Song a ,Singer b where a.SingerID=b.SingerID and SongName = '"+songName+"'";
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
                string sqlstr1 = "update Song set ClientCount = ClientCount +1 where SongID=" + s.SingerID;
                DBHelper.getNonQuery(sqlstr1);
            }
        }
    }
}
