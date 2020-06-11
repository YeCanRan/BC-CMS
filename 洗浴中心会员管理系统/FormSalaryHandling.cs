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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class FormSalaryHandling : Form
    {
        ArrayList SalaryRiseList = new ArrayList();
        int i = 0;
        public FormSalaryHandling()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand SalaryRise = new SqlCommand("select * from ViewEmployeeClass", GlobalClass.Connection);
                SqlDataReader data = SalaryRise.ExecuteReader();
                while (data.Read())
                {
                    SalaryRiseList.Add(new 洗浴中心会员管理系统.UserControlSalaryRiseList());
                    this.PanelSalaryRiseList.Controls.Add((UserControlSalaryRiseList)SalaryRiseList[i]);
                    this.PanelSalaryRiseList.Controls.SetChildIndex((UserControlSalaryRiseList)SalaryRiseList[i], 0);
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).Name = "SalaryRiseList" + i;
                    if (i % 2 == 0)
                        ((UserControlSalaryRiseList)SalaryRiseList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).Controls["LabelID"].Text = (i+1).ToString();
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).Controls["LabelClass"].Text = data[0].ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
            /*int SalaryRiseNumbers = 10;
            for (int i = 0; i < SalaryRiseNumbers; i++)
            {
                SalaryRiseList.Add(new 洗浴中心会员管理系统.UserControlSalaryRiseList());
                this.PanelSalaryRiseList.Controls.Add((UserControlSalaryRiseList)SalaryRiseList[i]);
                ((UserControlSalaryRiseList)SalaryRiseList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlSalaryRiseList)SalaryRiseList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlSalaryRiseList)SalaryRiseList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlSalaryRiseList)SalaryRiseList[i]).Name = "SalaryRiseList" + i;
                if (i % 2 == 0)
                    ((UserControlSalaryRiseList)SalaryRiseList[i]).BackColor = Color.FromArgb(25, 20, 25);
                ((UserControlSalaryRiseList)SalaryRiseList[i]).Controls["LabelID"].Text = (SalaryRiseNumbers - i).ToString();
            }*/
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                ((UserControlSalaryRiseList)SalaryRiseList[j]).Controls["TextBoxPrice"].Text = String.Empty;
            }
        }
    }
}