using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyKTV_Tools;

namespace MyKTV_Server
{
    public partial class frmSong : Form
    {
        public frmSong()
        {
            InitializeComponent();
        }

        public void showdgv()
        {
            string sqlStr = "select a.SongID,a.SongName,a.Songab,a.SongWordCount,b.SongTypeName,c.SingerName,a.Url,a.ClientCount,a.SongTypeID,a.SingerID from Song a,SongType b,Singer c where a.SingerID = c.SingerID and a.SongTypeID = b.SongTypeID";
            this.dgvSong.DataSource = DBHelper.getTable(sqlStr);
        }

        public void ade(string sqlStr)
        {
            try
            {
                int result = DBHelper.getNonQuery(sqlStr);
                if (result > 0)
                {
                    MessageBox.Show("操作成功","提示");
                    showdgv();
                }
                else
                {
                    MessageBox.Show("操作失败", "提示");
                    showdgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作出错，原因："+ex.Message,"提示");
                showdgv();
            }
        }

        public void cbosing()
        {
            this.cboSinger.Items.Clear();
            string sqlStr = "select SingerID,SingerName from Singer";
            this.cboSinger.DataSource = DBHelper.getTable(sqlStr);
            this.cboSinger.DisplayMember = "SingerName";
            this.cboSinger.ValueMember = "SingerID";
        }

        public void cbostype()
        {
            this.cboType.Items.Clear();
            string sqlStr = "select SongTypeID,SongTypeName from SongType";
            this.cboType.DataSource = DBHelper.getTable(sqlStr);
            this.cboType.DisplayMember = "SongTypeName";
            this.cboType.ValueMember = "SongTypeID";
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            this.ofdMusic.ShowDialog();
            this.txtFile.Text = this.ofdMusic.SafeFileName;
            axwmfLook.URL = this.ofdMusic.SafeFileName;
        }

        private void frmSong_Load(object sender, EventArgs e)
        {
            showdgv();
            cbosing();
            cbostype();
        }

        private void dgvSong_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvSong.SelectedRows.Count > 0)
            {
                this.txtID.Text = this.dgvSong.SelectedRows[0].Cells["SongID"].Value.ToString();
                this.txtName.Text = this.dgvSong.SelectedRows[0].Cells["SongName"].Value.ToString();
                this.txtAB.Text = this.dgvSong.SelectedRows[0].Cells["Songab"].Value.ToString();
                this.txtMath.Text = this.dgvSong.SelectedRows[0].Cells["SongWordCount"].Value.ToString();
                this.txtClick.Text = this.dgvSong.SelectedRows[0].Cells["ClientCount"].Value.ToString();

                string SingerName = this.dgvSong.SelectedRows[0].Cells["SingerName"].Value.ToString();
                //选择项下拉框
                for (int i = 0; i < this.cboSinger.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)this.cboSinger.Items[i];
                    if (item.Row[1].ToString() == SingerName)
                    {
                        this.cboSinger.SelectedIndex = i;
                        break;
                    }
                }

                string songtypename = this.dgvSong.SelectedRows[0].Cells["SongTypeName"].Value.ToString();
                //选择项下拉框
                for (int i = 0; i < this.cboType.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)this.cboType.Items[i];
                    if (item.Row[1].ToString() == songtypename)
                    {
                        this.cboType.SelectedIndex = i;
                        break;
                    }
                }

                string sqlStr = "Select RPath from ResourceUrl where RName='Song'";
                string path = DBHelper.getScalar(sqlStr).ToString();
                path += "\\" + this.dgvSong.SelectedRows[0].Cells["Url"].Value.ToString();
                this.txtFile.Text = path;
                axwmfLook.URL = path;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlStr = "update Song set SongName = '"+this.txtName.Text+"',Songab='"+this.txtAB.Text+"',SongWordCount="+this.txtMath.Text+",SongTypeID="+ this.cboType.SelectedValue + ",SingerID="+this.cboSinger.SelectedValue+",Url='"+this.txtFile.Text+"' where SongID="+this.txtID.Text;
            ade(sqlStr);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.txtAB.Text = "";
            this.txtMath.Text = "";
            this.txtClick.Text = "";
            this.cboType.SelectedIndex = 0;
            this.cboSinger.SelectedIndex = 0;
            this.txtFile.Text = "";
            showdgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlStr = "insert into song values('"+this.txtName.Text+"','"+this.txtAB.Text+"',"+this.txtMath.Text+","+this.cboType.SelectedValue+","+this.cboSinger.SelectedValue+",'"+this.txtFile.Text+"',"+this.txtClick.Text+")";
            ade(sqlStr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from Song where SongID="+this.txtID.Text;
            ade(sqlStr);
        }

        private void btnSongType_Click(object sender, EventArgs e)
        {
            frmSongType fst = new frmSongType();
            fst.Show();
        }

        private void ofdMusic_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
