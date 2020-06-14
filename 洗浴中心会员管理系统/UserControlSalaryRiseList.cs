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
using System.Text.RegularExpressions;

namespace 洗浴中心会员管理系统
{
    public partial class UserControlSalaryRiseList : UserControl
    {
        public UserControlSalaryRiseList()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认修改?", "消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    if (GlobalClass.Connection.State == ConnectionState.Open)
                        GlobalClass.Connection.Close();
                    GlobalClass.Connection.Open();
                    if (Regex.IsMatch(TextBoxPrice.Text, @"\d+"))
                    {
                        SqlCommand SalaryRiseCmd = new SqlCommand("SalaryRise", GlobalClass.Connection);
                        SalaryRiseCmd.CommandType = CommandType.StoredProcedure;
                        SalaryRiseCmd.Parameters.Add("@Class", SqlDbType.NChar, 6);
                        SalaryRiseCmd.Parameters.Add("@Salary", SqlDbType.Int);
                        SalaryRiseCmd.Parameters[0].Value = LabelClass.Text;
                        SalaryRiseCmd.Parameters[1].Value = Convert.ToInt32(TextBoxPrice.Text);
                        if (SalaryRiseCmd.ExecuteNonQuery() == 1)
                            MessageBox.Show("涨薪成功!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("涨薪失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxPrice.Text = String.Empty;
                        TextBoxPrice.Focus();
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