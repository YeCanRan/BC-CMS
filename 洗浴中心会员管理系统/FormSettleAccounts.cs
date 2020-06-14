using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class FormSettleAccounts : Form
    {
        ArrayList ConsumerList = new ArrayList();
        public FormSettleAccounts()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand SettleAccountsCmd = new SqlCommand("select * from ViewSettleAccounts", GlobalClass.Connection);
                SqlDataReader data = SettleAccountsCmd.ExecuteReader();
                int i = 0;
                while (data.Read())
                {
                    ConsumerList.Add(new 洗浴中心会员管理系统.UserControlConsumerList(this.TextBoxConsumerNo, this.CheckBoxIsMember, this.TextBoxCardNo, this.LabelPrice));
                    this.PanelConsumerList.Controls.Add((UserControlConsumerList)ConsumerList[i]);
                    this.PanelConsumerList.Controls.SetChildIndex((UserControlConsumerList)ConsumerList[i], 0);
                    ((UserControlConsumerList)ConsumerList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlConsumerList)ConsumerList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlConsumerList)ConsumerList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlConsumerList)ConsumerList[i]).Name = "ConsumerList" + i;
                    if (i % 2 == 0)
                        ((UserControlConsumerList)ConsumerList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlConsumerList)ConsumerList[i]).Controls["LabelID"].Text = (i + 1).ToString();
                    ((UserControlConsumerList)ConsumerList[i]).Controls["LabelNo"].Text = "号 牌 : " + data[0].ToString();
                    ((UserControlConsumerList)ConsumerList[i]).Controls["LabelSex"].Text = "性 别 : " + data[1].ToString();
                    ((UserControlConsumerList)ConsumerList[i]).Controls["LabelAmountOfMoney"].Text = "消费金额 : " + data[2].ToString();
                    ((UserControlConsumerList)ConsumerList[i]).Controls["LabelCardNo"].Text = "会员卡号 : " + data[3].ToString();
                    if (data[3].ToString() == "000000")
                    {
                        ((UserControlConsumerList)ConsumerList[i]).Controls["LabelIsMember"].Text = "非会员";
                        ((UserControlConsumerList)ConsumerList[i]).Controls["LabelCardNo"].Text = "会员卡号 : 000000";
                    }
                    else
                        ((UserControlConsumerList)ConsumerList[i]).Controls["LabelIsMember"].Text = "会 员";
                    i++;
                }
                data.Close();
                GlobalClass.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void CheckBoxIsMember_CheckedChanged(object sender, EventArgs e)
        {
            if (GlobalClass.Connection.State == ConnectionState.Open)
                GlobalClass.Connection.Close();
            GlobalClass.Connection.Open();
            SqlCommand SettleAccountsCmd = new SqlCommand("select * from ViewSettleAccounts", GlobalClass.Connection);
            SqlDataReader data = SettleAccountsCmd.ExecuteReader();
            while (data.Read())
            {
                if (TextBoxConsumerNo.Text == data[0].ToString())
                    TextBoxCardNo.Text = data[3].ToString();
            }
            data.Close();
            GlobalClass.Connection.Close();
            if (CheckBoxIsMember.CheckState == CheckState.Unchecked)
                TextBoxCardNo.Text = String.Empty;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                if (CheckBoxIsMember.CheckState == CheckState.Unchecked)
                {
                    if (Regex.IsMatch(TextBoxConsumerNo.Text, @"\d{3}") && TextBoxConsumerNo.TextLength <= 3)
                    {
                        SqlCommand SettleAccountsCmd = new SqlCommand("select Price from ViewSettleAccounts where No=" + TextBoxConsumerNo.Text.ToString(), GlobalClass.Connection);
                        LabelPrice.Text = SettleAccountsCmd.ExecuteScalar().ToString() + "元";
                        GlobalClass.Connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxConsumerNo.Text = String.Empty;
                        TextBoxConsumerNo.Focus();
                    }
                }
                else if (CheckBoxIsMember.CheckState == CheckState.Checked && TextBoxCardNo.Text != String.Empty && TextBoxCardNo.Text != "000000")
                {
                    SqlCommand SettleAccountsCmd = new SqlCommand("select Price from ViewSettleAccounts where No=" + TextBoxConsumerNo.Text.ToString() + " and CardNo=" + TextBoxCardNo.Text.ToString(), GlobalClass.Connection);
                    SqlDataReader data = SettleAccountsCmd.ExecuteReader();
                    data.Read();
                    LabelPrice.Text = ((int)data[0] / 2).ToString() + "元";
                    data.Close();
                    GlobalClass.Connection.Close();
                }
                else if (CheckBoxIsMember.CheckState == CheckState.Checked && TextBoxCardNo.Text == "000000")
                {
                    SqlCommand SettleAccountsCmd = new SqlCommand("select Price from ViewSettleAccounts where No=" + TextBoxConsumerNo.Text.ToString() + " and CardNo=" + TextBoxCardNo.Text.ToString(), GlobalClass.Connection);
                    SqlDataReader data = SettleAccountsCmd.ExecuteReader();
                    data.Read();
                    LabelPrice.Text = data[0].ToString() + "元";
                    data.Close();
                    GlobalClass.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            FormPay pay = new FormPay();
            pay.Show();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxConsumerNo.Text = String.Empty;
            CheckBoxIsMember.CheckState = CheckState.Unchecked;
            TextBoxCardNo.Text = String.Empty;
            LabelPrice.Text = "0.00元";
        }
    }
}