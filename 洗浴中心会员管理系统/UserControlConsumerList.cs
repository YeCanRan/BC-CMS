using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace 洗浴中心会员管理系统
{
    public partial class UserControlConsumerList : UserControl
    {
        TextBox TempRef1;
        CheckBox TempRef2;
        TextBox TempRef3;
        Label TempRef4;
        public UserControlConsumerList(TextBox TextBoxConsumerNo, CheckBox CheckBoxIsMember, TextBox TextBoxCardNo, Label LabelPrice)
        {
            InitializeComponent();
            TempRef1 = TextBoxConsumerNo;
            TempRef2 = CheckBoxIsMember;
            TempRef3 = TextBoxCardNo;
            TempRef4 = LabelPrice;
        }
        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            TempRef1.Text = this.Controls["LabelNo"].Text.Substring(6);
            if (this.Controls["LabelCardNo"].Text.Substring(7) == "000000")
            {
                TempRef2.CheckState = CheckState.Unchecked;
                TempRef3.Text = String.Empty;
                TempRef4.Text = this.Controls["LabelAmountOfMoney"].Text.Substring(7) + "元";
            }
            else
            {
                TempRef2.CheckState = CheckState.Checked;
                TempRef3.Text = this.Controls["LabelCardNo"].Text.Substring(7);
                TempRef4.Text = (Convert.ToInt32(this.Controls["LabelAmountOfMoney"].Text.Substring(7)) / 2) + "元";
            }
        }
    }
}