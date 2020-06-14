using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class FormMemberRecharge : Form
    {
        ArrayList RechargePriceList = new ArrayList();
        public FormMemberRecharge()
        {
            InitializeComponent();

            int RechargePriceNumbers = 10;
            for (int i = 0; i < RechargePriceNumbers; i++)
            {
                RechargePriceList.Add(new 洗浴中心会员管理系统.UserControlRechargePriceList(this.LabelPrice));
                this.PanelRechargePriceList.Controls.Add((UserControlRechargePriceList)RechargePriceList[i]);
                ((UserControlRechargePriceList)RechargePriceList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlRechargePriceList)RechargePriceList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlRechargePriceList)RechargePriceList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlRechargePriceList)RechargePriceList[i]).Name = "RechargePriceList" + i;
                if (i % 2 == 0)
                    ((UserControlRechargePriceList)RechargePriceList[i]).BackColor = Color.FromArgb(25, 20, 25);
                ((UserControlRechargePriceList)RechargePriceList[i]).Controls["LabelCardNo"].Text = (RechargePriceNumbers - i).ToString();
                ((UserControlRechargePriceList)RechargePriceList[i]).Controls["LabelRechargePrice"].Text = ((RechargePriceNumbers - i) * 100).ToString();
                ((UserControlRechargePriceList)RechargePriceList[i]).Controls["LabelGiftPrice"].Text = ((int)((RechargePriceNumbers - i) * Math.Sqrt(RechargePriceNumbers - i) / 10.0 * 10) * 10).ToString();
            }
        }

        private void ButtonRecharge_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                if (Regex.IsMatch(TextBoxCardNumber.Text, @"2\d{5}") && TextBoxPasswrod.Text != String.Empty)
                {
                    SqlCommand MemberNoCmd = new SqlCommand("select CardNo,Password from Member", GlobalClass.Connection);
                    SqlDataReader data = MemberNoCmd.ExecuteReader();
                    int i = 0;
                    while (data.Read())
                    {
                        if (data[0].ToString() == TextBoxCardNumber.Text && data[1].ToString() == GlobalClass.MD5(TextBoxPasswrod.Text))
                        {
                            data.Close();
                            SqlCommand RechargeCmd = new SqlCommand("Recharge", GlobalClass.Connection);
                            RechargeCmd.CommandType = CommandType.StoredProcedure;
                            RechargeCmd.Parameters.Add("@CardNo", SqlDbType.NChar, 6);
                            RechargeCmd.Parameters.Add("@Password", SqlDbType.NChar, 32);
                            RechargeCmd.Parameters.Add("@Balance", SqlDbType.Int);
                            RechargeCmd.Parameters[0].Value = TextBoxCardNumber.Text;
                            RechargeCmd.Parameters[1].Value = GlobalClass.MD5(TextBoxPasswrod.Text);
                            RechargeCmd.Parameters[2].Value = Convert.ToInt32(LabelPrice.Text);
                            if (RechargeCmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("提交成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                                MessageBox.Show("提交失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        i++;
                    }
                    GlobalClass.Connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxCardNumber.Text = String.Empty;
                    TextBoxPasswrod.Text = String.Empty;
                    TextBoxCardNumber.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxCardNumber.Text = String.Empty;
            this.TextBoxPasswrod.Text = String.Empty;
        }
    }
}