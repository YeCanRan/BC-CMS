using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 洗浴中心会员管理系统
{
    public partial class UserControlCouponList : UserControl
    {
        public UserControlCouponList()
        {
            InitializeComponent();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此券?", "消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    if (GlobalClass.Connection.State == ConnectionState.Open)
                        GlobalClass.Connection.Close();
                    GlobalClass.Connection.Open();
                    SqlCommand DeleteCmd = new SqlCommand("CouponDelete", GlobalClass.Connection);
                    DeleteCmd.CommandType = CommandType.StoredProcedure;
                    DeleteCmd.Parameters.Add("@No", SqlDbType.Int);
                    DeleteCmd.Parameters[0].Value = LabelID.Text;
                    if (DeleteCmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("删除成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GlobalClass.Connection.Close();
                }
            }
        }
    }
}