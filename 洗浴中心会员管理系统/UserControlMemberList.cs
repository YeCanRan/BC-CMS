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
    public partial class UserControlMemberList : UserControl
    {
        public UserControlMemberList()
        {
            InitializeComponent();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            FormMemberInformationEdit Edit = new FormMemberInformationEdit(this.LabelMemberNo);
            Edit.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此会员?", "消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand DeleteMemberCmd = new SqlCommand("MemberDelete", GlobalClass.Connection);
                DeleteMemberCmd.CommandType = CommandType.StoredProcedure;
                DeleteMemberCmd.Parameters.Add("@CardNo", SqlDbType.NChar, 6);
                DeleteMemberCmd.Parameters[0].Value = LabelMemberNo.Text.Substring(7);
                if (DeleteMemberCmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("删除成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("删除失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}