using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class UserControlEmployeeList : UserControl
    {
        public UserControlEmployeeList()
        {
            InitializeComponent();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            FormEmployeeInformationEdit Edit = new FormEmployeeInformationEdit();
            Edit.ShowDialog();
        }
    }
}