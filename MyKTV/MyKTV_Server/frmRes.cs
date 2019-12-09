using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyKTV_Tools;
using System.Data.SqlClient;

namespace MyKTV_Server
{
    public partial class frmRes : Form
    {
        public frmRes() 
        {
            InitializeComponent();
        }

        private void btnSingerpicmore_Click(object sender, EventArgs e)
        {
            this.fbdSingerPic.ShowDialog();
            this.txtSingerpic.Text = this.fbdSingerPic.SelectedPath;
        }

        private void lbSingerPic_Click(object sender, EventArgs e)
        {

        }

        private void btnSongpicmore_Click(object sender, EventArgs e)
        {
            this.fbdSongPic.ShowDialog();
            this.txtSongpic.Text = this.fbdSongPic.SelectedPath;
        }

        private void btnsongmore_Click(object sender, EventArgs e)
        {
            this.fbdSong.ShowDialog();
            this.txtSong.Text = this.fbdSong.SelectedPath;
        }

        private void frmResAdd_Load(object sender, EventArgs e)
        {
            showRes();
        }

        public void showRes()
        {
            string sqlStr = "select * from ResourceUrl";
            SqlDataReader dr = DBHelper.GetReader(sqlStr);
            while (dr.Read())//判断下一行是否有数据
            {
                switch (dr["RName"].ToString())
                {
                    case "SingerPic":
                        this.txtSingerpic.Text = dr["RPath"].ToString();
                        break;
                    case "SongPic":
                        this.txtSongpic.Text = dr["RPath"].ToString();
                        break;
                    case "Song":
                        this.txtSong.Text = dr["RPath"].ToString();
                        break;
                }
            }
            DBHelper.dr.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showRes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //修改三个数据内容
            string sql1 = "update ResourceUrl set RPath='"+this.txtSingerpic.Text+"' where RName = 'SingerPic'";
            string sql2 = "update ResourceUrl set RPath='" + this.txtSongpic.Text + "' where RName = 'SongPic'";
            string sql3 = "update ResourceUrl set RPath='" + this.txtSong.Text + "' where RName = 'Song'";

            int result1 = DBHelper.getNonQuery(sql1);
            int result2 = DBHelper.getNonQuery(sql2);
            int result3 = DBHelper.getNonQuery(sql3);

            if (result1 > 0 && result2 > 0 && result3 >0)
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }
    }
}
