﻿using System;
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
    public partial class FormMemberInformation : Form
    {
        ArrayList MemberList = new ArrayList();
        public FormMemberInformation()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand MemberInformationCmd = new SqlCommand("select * from ViewMemberInformation", GlobalClass.Connection);
                SqlDataReader data = MemberInformationCmd.ExecuteReader();
                int i = 0;
                while (data.Read())
                {
                    MemberList.Add(new 洗浴中心会员管理系统.UserControlMemberList());
                    this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                    this.PanelMemberList.Controls.SetChildIndex((UserControlMemberList)MemberList[i], 0);
                    ((UserControlMemberList)MemberList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlMemberList)MemberList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlMemberList)MemberList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlMemberList)MemberList[i]).Name = "MemberList" + i;
                    if (i % 2 == 0)
                        ((UserControlMemberList)MemberList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlMemberList)MemberList[i]).Controls["LabelMemberNo"].Text = "会员卡号 : " + data[0].ToString();
                    ((UserControlMemberList)MemberList[i]).Controls["LabelName"].Text = "姓 名 : " + data[1].ToString();
                    ((UserControlMemberList)MemberList[i]).Controls["LabelSex"].Text = "性 别 : " + data[2].ToString();
                    ((UserControlMemberList)MemberList[i]).Controls["LabelTel"].Text = "联系电话 : " + data[3].ToString();
                    ((UserControlMemberList)MemberList[i]).Controls["LabelAddress"].Text = "联系地址 : " + data[4].ToString();
                    ((UserControlMemberList)MemberList[i]).Controls["LabelHandleDate"].Text = "办理日期 : " + data[5].ToString().Substring(0, 9);
                    ((UserControlMemberList)MemberList[i]).Controls["LabelBalance"].Text = "余 额 : " + data[6].ToString();
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

        private void ButtonSearchByCardNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                if (Regex.IsMatch(TextBoxCardNo.Text, @"2\d{5}"))
                {
                    SqlCommand SearchByCardNoCmd = new SqlCommand("select * from ViewMemberInformation where CardNo=" + TextBoxCardNo.Text, GlobalClass.Connection);
                    SqlDataReader data = SearchByCardNoCmd.ExecuteReader();
                    data.Read();
                    for (int i = 0; i < MemberList.Count; i++)
                    {
                        if (((UserControlMemberList)MemberList[i]).Controls["LabelMemberNo"].Text.Substring(7) == data[0].ToString())
                        {
                            this.PanelMemberList.Controls.Clear();
                            this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                        }
                    }
                    data.Close();
                }
                else
                {
                    MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxCardNo.Text = String.Empty;
                    TextBoxCardNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }

        }

        private void ButtonSearchByTel_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                if (Regex.IsMatch(TextBoxTel.Text, @"1\d{10}"))
                {
                    SqlCommand SearchByTelCmd = new SqlCommand("select * from ViewMemberInformation where Tel=" + TextBoxTel.Text, GlobalClass.Connection);
                    SqlDataReader data = SearchByTelCmd.ExecuteReader();
                    data.Read();
                    for (int i = 0; i < MemberList.Count; i++)
                    {
                        if (((UserControlMemberList)MemberList[i]).Controls["LabelTel"].Text.Substring(7) == data[3].ToString())
                        {
                            this.PanelMemberList.Controls.Clear();
                            this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                        }
                    }
                    data.Close();
                }
                else
                {
                    MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxTel.Text = String.Empty;
                    TextBoxTel.Focus();
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
            this.TextBoxCardNo.Text = String.Empty;
            this.TextBoxTel.Text = String.Empty;
        }
    }
}