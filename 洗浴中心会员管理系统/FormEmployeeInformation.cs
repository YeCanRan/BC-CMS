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
    public partial class FormEmployeeInformation : Form
    {
        ArrayList EmployeeList = new ArrayList();
        public FormEmployeeInformation()
        {
            InitializeComponent();
            int EmployeeNumbers = 30;
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
            }
        }
    }
}