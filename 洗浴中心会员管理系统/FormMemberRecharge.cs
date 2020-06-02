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
    public partial class FormMemberRecharge : Form
    {
        ArrayList RechargePriceList = new ArrayList();
        public FormMemberRecharge()
        {
            InitializeComponent();

            int RechargePriceNumbers = 10;
            for (int i = 0; i < RechargePriceNumbers; i++)
            {
                RechargePriceList.Add(new 洗浴中心会员管理系统.UserControlRechargePriceList());
                this.PanelRechargePriceList.Controls.Add((UserControlRechargePriceList)RechargePriceList[i]);
                ((UserControlRechargePriceList)RechargePriceList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlRechargePriceList)RechargePriceList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlRechargePriceList)RechargePriceList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlRechargePriceList)RechargePriceList[i]).Name = "RechargePriceList" + i;
                if (i % 2 == 0)
                {
                    ((UserControlRechargePriceList)RechargePriceList[i]).BackColor = Color.FromArgb(25, 20, 25);
                }
                else
                {
                    ((UserControlRechargePriceList)RechargePriceList[i]).BackColor = Color.FromArgb(35, 30, 35);
                }
                ((UserControlRechargePriceList)RechargePriceList[i]).Controls["LabelID"].Text=(RechargePriceNumbers-i).ToString();
                ((UserControlRechargePriceList)RechargePriceList[i]).Controls["LabelRechargePrice"].Text = ((RechargePriceNumbers - i)*100).ToString();
                ((UserControlRechargePriceList)RechargePriceList[i]).Controls["LabelGiftPrice"].Text = ((int)((RechargePriceNumbers - i) * Math.Sqrt(RechargePriceNumbers - i) / 10.0 * 10) * 10).ToString();
            }
        }
    }
}