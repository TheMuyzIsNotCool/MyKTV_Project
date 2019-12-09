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
    public partial class frmSongABorder : Form
    {
        public frmSongABorder()
        {
            InitializeComponent();
        }


        private void showsong(string ab)
        {


            lvShow.Items.Clear();
            //查询所有匹配的数字歌曲
            Sound[] songs = new Sound[50];
            //根据歌曲列表查询相应的内容
            string sqlStr = "select * from Song a ,Singer b where a.SingerID=b.SingerID and Songab like '%"+ ab + "%'";
            
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

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (this.txtAB.Text != null)
            {
                Button btn = (Button)sender;
                switch (btn.Text)
                {
                    case "重置":
                        this.txtAB.Text = "";
                        break;
                    case "删除":
                        this.txtAB.Text = this.txtAB.Text.Substring(0, this.txtAB.Text.Length - 1);
                        break;
                    default:
                        this.txtAB.Text += btn.Text;
                        break;
                }
            }              
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.txtAB.Text += btn.Text;
        }

        private void txtAB_TextChanged(object sender, EventArgs e)
        {

            if (this.txtAB.Text != "")
            {
                showsong(this.txtAB.Text);
            }
            else
            {

            }
        }
    }
}
