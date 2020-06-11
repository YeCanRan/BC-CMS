using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace 洗浴中心会员管理系统
{
    public partial class UserControlMaterialList : UserControl
    {
        public UserControlMaterialList()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认更改?", "消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (Regex.IsMatch(TextBoxIncrement.Text, @"\d+") && Convert.ToInt32(LabelTotalReserves.Text) - Convert.ToInt32(LabelCurrentReserve.Text) >= Convert.ToInt32(TextBoxIncrement.Text))
                {
                    try
                    {
                        if (GlobalClass.Connection.State == ConnectionState.Open)
                            GlobalClass.Connection.Close();
                        GlobalClass.Connection.Open();
                        SqlCommand MaterialCmd = new SqlCommand("MaterialAdd", GlobalClass.Connection);
                        MaterialCmd.CommandType = CommandType.StoredProcedure;
                        MaterialCmd.Parameters.Add("@Name", SqlDbType.VarChar, 8);
                        MaterialCmd.Parameters.Add("@Numbers", SqlDbType.Int);
                        MaterialCmd.Parameters[0].Value = LabelName.Text;
                        MaterialCmd.Parameters[1].Value = Convert.ToInt32(TextBoxIncrement.Text);
                        if (MaterialCmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("更改成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("更改失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("内容不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxIncrement.Text = String.Empty;
                    TextBoxIncrement.Focus();
                }
            }
        }
    }
}