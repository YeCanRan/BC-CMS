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
    public partial class FormCouponIssue : Form
    {
        ArrayList CouponList = new ArrayList();
        public FormCouponIssue()
        {
            InitializeComponent();
            int CouponNumbers = 30;
            for (int i = 0; i < CouponNumbers; i++)
            {
                CouponList.Add(new 洗浴中心会员管理系统.UserControlCouponList());
                this.PanelCouponList.Controls.Add((UserControlCouponList)CouponList[i]);
                ((UserControlCouponList)CouponList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlCouponList)CouponList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlCouponList)CouponList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlCouponList)CouponList[i]).Name = "CouponList" + i;
                if (i % 2 == 0)
                    ((UserControlCouponList)CouponList[i]).BackColor = Color.FromArgb(25, 20, 25);
                ((UserControlCouponList)CouponList[i]).Controls["LabelID"].Text = (CouponNumbers - i).ToString();
            }
        }
    }
}