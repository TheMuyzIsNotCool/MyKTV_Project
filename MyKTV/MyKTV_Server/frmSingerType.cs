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

namespace MyKTV_Server
{
    public partial class frmSingerType : Form
    {
        public frmSingerType()
        {
            InitializeComponent();
        }

        public void ade(string sqlStr)
        {
            try
            {
                int result = DBHelper.getNonQuery(sqlStr);
                if (result > 0)
                {
                    MessageBox.Show("操作成功", "提示");
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
                MessageBox.Show("操作出错，原因：" + ex.Message, "提示");
                showdgv();
            }
        }

        public void showdgv()
        {
            string sqlstr = "select * from SingerType";
            this.dgvsingerinfo.DataSource = DBHelper.getTable(sqlstr);
        }



        private void frmSingerType_Load(object sender, EventArgs e)
        {
            showdgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlstr = "insert into SingerType values('"+this.txtName.Text+"')";
            ade(sqlstr);
        }

        private void gbEdit_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlstr = "update SingerType set SingerTypeName ='"+this.txtName.Text+"' where SingerTypeID ="+this.txtID.Text;
            ade(sqlstr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlstr = "delete from SingerType where SingerTypeID = "+this.txtID.Text;
            ade(sqlstr);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showdgv();
            this.txtID.Text = "";
            this.txtName.Text = "";
        }

        private void dgvsingerinfo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvsingerinfo.SelectedRows.Count > 0 )
            {
                this.txtID.Text = this.dgvsingerinfo.SelectedRows[0].Cells["SingerTypeID"].Value.ToString();
                this.txtName.Text = this.dgvsingerinfo.SelectedRows[0].Cells["SingerTypeName"].Value.ToString();
            }
            
        }
    }
}
