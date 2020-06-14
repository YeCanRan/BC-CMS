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
    public partial class UserControlPriceList : UserControl
    {
        public UserControlPriceList()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认更改价格?", "消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (!Regex.IsMatch(TextBoxPresentPrice.Text, @"\d+"))
                {
                    MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxPresentPrice.Text = String.Empty;
                    TextBoxPresentPrice.Focus();
                }
                else
                {
                    try
                    {
                        if (GlobalClass.Connection.State == ConnectionState.Open)
                            GlobalClass.Connection.Close();
                        GlobalClass.Connection.Open();
                        SqlCommand PriceCmd = new SqlCommand("PriceChange", GlobalClass.Connection);
                        PriceCmd.CommandType = CommandType.StoredProcedure;
                        PriceCmd.Parameters.Add("@Name", SqlDbType.VarChar, 16);
                        PriceCmd.Parameters.Add("@Price", SqlDbType.Int);
                        PriceCmd.Parameters[0].Value = LabelName.Text;
                        PriceCmd.Parameters[1].Value = Convert.ToInt32(TextBoxPresentPrice.Text);
                        if (PriceCmd.ExecuteNonQuery() == 1)
                            MessageBox.Show("更改成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("更改失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}