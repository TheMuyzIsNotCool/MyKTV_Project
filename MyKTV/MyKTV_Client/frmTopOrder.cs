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
    public partial class frmTopOrder : Form
    {
        public frmTopOrder()
        {
            InitializeComponent();
        }

        private void showsong()
        {
            
            //查询所有匹配的数字歌曲
            Sound[] songs = new Sound[50];
            //根据Clicked降序显示
            string sqlstr = "select SongID,SongName,a.SingerID,SingerName,ClientCount,url from Song a,Singer b where a.SingerID = b.SingerID order by ClientCount desc";
            DBHelper.GetReader(sqlstr);
            while (DBHelper.dr.Read())
            {
                Sound s = new Sound();
                s.SongID = (int)DBHelper.dr["SongID"];
                s.SongName = DBHelper.dr["SongName"].ToString();
                s.SingerName = DBHelper.dr["SingerName"].ToString();
                s.Url = DBHelper.dr["Url"].ToString();
                s.SingerID = (int)DBHelper.dr["SingerID"];

                ListViewItem item = new ListViewItem(s.SongName);
                item.SubItems.Add(s.SingerName);
                lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
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

        private void frmTopOrder_Load(object sender, EventArgs e)
        {
            showsong();
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count > 0)
            {
                string SongName = this.lvShow.SelectedItems[0].Text;
                string sqlstr = "select b.SingerID,SongID,SongName,SingerName,Url from Song a, Singer b where a.SingerID = b.SingerID and SongName = '" + SongName +"'";
                DBHelper.GetReader(sqlstr);
                Sound s = null;
                if (DBHelper.dr.Read())
                {
                    s = new Sound();
                    s.SongID = (int)DBHelper.dr["SongID"];
                    s.SongName = DBHelper.dr["SongName"].ToString();
                    s.SingerName = DBHelper.dr["SingerName"].ToString();
                    s.Url = DBHelper.dr["Url"].ToString();
                    s.SingerID = (int)DBHelper.dr["SingerID"];

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
                string sqlstr1 = "update Song set ClientCount = ClientCount+1 where SongID=" + s.SingerID;
                DBHelper.getNonQuery(sqlstr1);
            }
            
        }
    }
}
