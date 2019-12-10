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
    public partial class frmAdminEdit : Form
    {
        public frmAdminEdit()
        {
            InitializeComponent();
        }

        public void showdgv()
        {
            string sqlStr = "select * from AdminInfo";
            dgvsingerinfo.DataSource = DBHelper.getTable(sqlStr);
        }

        public void ade(string sqlStr)
        {
            try
            {
                int result = DBHelper.getNonQuery(sqlStr);
                if (result > 0)
                {
                    MessageBox.Show("操作成功", "提示");
                }
                else
                {
                    MessageBox.Show("操作失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败，出错原因："+ex.Message,"提示");
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text == this.txtPwd2.Text)
            {
                string sqlstr = "insert into AdminInfo values('" + this.txtName.Text + "','" + this.txtPwd.Text + "')";
                ade(sqlstr);
            }
            else
            {
                MessageBox.Show("两次输入密码不一致，请检查后重新输入","提示");
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text == this.txtPwd2.Text)
            {
                string sqlstr = "update AdminInfo set APwd = '"+this.txtPwd.Text+"' where AID = "+this.txtID.Text;
                ade(sqlstr);
            }
            else
            {
                MessageBox.Show("两次输入密码不一致，请检查后重新输入", "提示");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlstr = "delete from AdminInfo where AID="+this.txtID.Text;
            ade(sqlstr);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.txtPwd.Text = "";
            this.txtPwd2.Text = "";
        }

        private void dgvsingerinfo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvsingerinfo.SelectedRows.Count > 0)
            {
                this.txtID.Text = this.dgvsingerinfo.SelectedRows[0].Cells["AID"].Value.ToString();
                this.txtName.Text = this.dgvsingerinfo.SelectedRows[0].Cells["AName"].Value.ToString();
                this.txtPwd.Text = this.dgvsingerinfo.SelectedRows[0].Cells["APwd"].Value.ToString();
            }
        }
    }
}
