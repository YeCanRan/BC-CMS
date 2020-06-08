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
    public partial class FormEmployeeInformation : Form
    {
        ArrayList EmployeeList = new ArrayList();
        public FormEmployeeInformation()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand EmployeeInformationCmd = new SqlCommand("select * from ViewEmployeeInformation", GlobalClass.Connection);
                SqlDataReader data = EmployeeInformationCmd.ExecuteReader();
                int i = 0;
                while (data.Read())
                {
                    EmployeeList.Add(new 洗浴中心会员管理系统.UserControlEmployeeList());
                    this.PanelEmployeeList.Controls.Add((UserControlEmployeeList)EmployeeList[i]);
                    this.PanelEmployeeList.Controls.SetChildIndex((UserControlEmployeeList)EmployeeList[i], 0);
                    ((UserControlEmployeeList)EmployeeList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlEmployeeList)EmployeeList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlEmployeeList)EmployeeList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlEmployeeList)EmployeeList[i]).Name = "EmployeeList" + i;
                    if (i % 2 == 0)
                        ((UserControlEmployeeList)EmployeeList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelEmployeeNo"].Text = data[0].ToString();
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelName"].Text = data[1].ToString();
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelSex"].Text = data[2].ToString();
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelTel"].Text = data[3].ToString();
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelAddress"].Text = data[4].ToString();
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelDateOfEmployment"].Text = data[5].ToString().Substring(0,9);
                    ((UserControlEmployeeList)EmployeeList[i]).Controls["LabelBankCardNo"].Text = data[6].ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
            /*int EmployeeNumbers = 30;
            for (int i = 0; i < EmployeeNumbers; i++)
            {
                EmployeeList.Add(new 洗浴中心会员管理系统.UserControlEmployeeList());
                this.PanelEmployeeList.Controls.Add((UserControlEmployeeList)EmployeeList[i]);
                ((UserControlEmployeeList)EmployeeList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlEmployeeList)EmployeeList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlEmployeeList)EmployeeList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlEmployeeList)EmployeeList[i]).Name = "EmployeeList" + i;
                if (i % 2 == 0)
                    ((UserControlEmployeeList)EmployeeList[i]).BackColor = Color.FromArgb(25, 20, 25);
            }*/
        }

        private void ButtonSearchByEmployeeNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand SearchByNoCmd = new SqlCommand("select * from ViewEmployeeInformation where No="+TextBoxEmployeeNo.Text,GlobalClass.Connection);
                SqlDataReader data = SearchByNoCmd.ExecuteReader();
                data.Read();
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (((UserControlEmployeeList)EmployeeList[i]).Controls["LabelEmployeeNo"].Text == data[0].ToString())
                    {
                        this.PanelEmployeeList.Controls.Clear();
                        this.PanelEmployeeList.Controls.Add((UserControlEmployeeList)EmployeeList[i]);
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

        private void ButtonSearchByTel_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand SearchByTelCmd = new SqlCommand("select * from ViewEmployeeInformation where Tel="+TextBoxTel.Text,GlobalClass.Connection);
                SqlDataReader data = SearchByTelCmd.ExecuteReader();
                data.Read();
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (((UserControlEmployeeList)EmployeeList[i]).Controls["LabelTel"].Text == data[3].ToString())
                    {
                        this.PanelEmployeeList.Controls.Clear();
                        this.PanelEmployeeList.Controls.Add((UserControlEmployeeList)EmployeeList[i]);
                    }
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
            this.TextBoxEmployeeNo.Text = String.Empty;
            this.TextBoxTel.Text = String.Empty;
        }
    }
}