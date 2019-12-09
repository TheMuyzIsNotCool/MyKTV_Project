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
    public partial class frmStarList : Form
    {

        public int singerTypeID;
        public string singerGender;

        public frmStarList()
        {
            InitializeComponent();
        }

        private void frmStarList_Load(object sender, EventArgs e)
        {
            Sound[] songs = new Sound[50];
            string sqlstr = "select SingerID,SingerName,a.SingerTypeID,SingerTypeName,Gender,Photo from Singer a,SingerType b where a.SingerTypeID = b.SingerTypeID and a.SingerTypeID=" + singerTypeID + " and gender = '" + singerGender + "'";
            DBHelper.GetReader(sqlstr);
                while (DBHelper.dr.Read())
            {
                int index = 0;
                //获取当前列表的名字
                string photoName = DBHelper.dr["Photo"].ToString();
                //获取图片在列表的下标
                index = this.ilSinger.Images.IndexOfKey(photoName);
                ListViewItem item = new ListViewItem(DBHelper.dr["SingerName"].ToString(), index);
                
                

                lvShow.Items.Add(item);
            }
            DBHelper.dr.Close();
            DBHelper.conn.Close();
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count>0)
            {

            }
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

        private void pbService_Click(object sender, EventArgs e)
        {

        }

        private void lvShow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.lvShow.SelectedItems.Count>0)
            {
                frmStarSonglist fssl = new frmStarSonglist();
                fssl.lbTitle.Text = this.lvShow.SelectedItems[0].Text;
                fssl.ShowDialog();
                this.Close();
            }
        }
    }
}
