using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

            /*int MemberNumbers = 30;
            for (int i = 0; i < MemberNumbers; i++)
            {
                MemberList.Add(new 洗浴中心会员管理系统.UserControlMemberList());
                this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                ((UserControlMemberList)MemberList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlMemberList)MemberList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlMemberList)MemberList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlMemberList)MemberList[i]).Name = "MemberList" + i;
                if (i % 2 == 0)
                    ((UserControlMemberList)MemberList[i]).BackColor = Color.FromArgb(25, 20, 25);
            }*/
        }

        private void ButtonSearchByCardNo_Click(object sender, EventArgs e)
        {
            try
            {
                //int i = 0;
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand SearchByCardNoCmd = new SqlCommand("select * from ViewMemberInformation where CardNo=" + TextBoxCardNo.Text, GlobalClass.Connection);
                SqlDataReader data = SearchByCardNoCmd.ExecuteReader();
                data.Read();
                //MessageBox.Show(data[0].ToString(), "");
                for (int i = 0; i < MemberList.Count; i++)
                {
                    //MessageBox.Show("Mark"+i, "消息");
                    if (((UserControlMemberList)MemberList[i]).Controls["LabelMemberNo"].Text.Substring(7) == data[0].ToString())
                    {
                        //MessageBox.Show("Mark!");
                        this.PanelMemberList.Controls.Clear();
                        this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                    }
                }
                data.Close();
                /*while (data.Read())
                {
                    if (((UserControlMemberList)MemberList[i]).Controls["LabelMemberNo"].Text == data[0].ToString())
                    {
                        MessageBox.Show("Mark1!", "消息");
                        this.PanelMemberList.Controls.Clear();
                        this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                    }
                    i++;
                    MessageBox.Show("Mark" + i.ToString(), "消息");
                }
                MessageBox.Show("检索失败!", "消息");*/
                /*foreach (var member in MemberList)
                {
                    data.Read();
                    if (((UserControlMemberList)member).Controls["LabelMemberNo"].Text == data[0].ToString())
                    {
                        //(MemberList[i])
                        for (int j = 0; j != i; j++)
                        {
                            ((UserControlMemberList)MemberList[j]).Hide();
                        }
                    }
                    i++;
                }*/
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