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
    public partial class FormMemberInformation : Form
    {
        ArrayList MemberList = new ArrayList();
        public FormMemberInformation()
        {
            InitializeComponent();
            int MemberNumbers = 30;
            for (int i = 0; i < MemberNumbers; i++)
            {
                MemberList.Add(new 洗浴中心会员管理系统.UserControlMemberList());
                this.PanelMemberList.Controls.Add((UserControlMemberList)MemberList[i]);
                ((UserControlMemberList)MemberList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlMemberList)MemberList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlMemberList)MemberList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlMemberList)MemberList[i]).Name = "MemberList" + i;
                if (i % 2 == 0)
                {
                    ((UserControlMemberList)MemberList[i]).BackColor = Color.FromArgb(25, 20, 25);
                }
                else
                {
                    ((UserControlMemberList)MemberList[i]).BackColor = Color.FromArgb(35, 30, 35);
                }
            }
        }
    }
}
