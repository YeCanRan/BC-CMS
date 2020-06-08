using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class FormSalaryHandling : Form
    {
        ArrayList SalaryRiseList = new ArrayList();
        public FormSalaryHandling()
        {
            InitializeComponent();
            int SalaryRiseNumbers = 10;
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
            }
        }
    }
}