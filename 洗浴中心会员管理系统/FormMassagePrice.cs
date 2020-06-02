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
    public partial class FormMassagePrice : Form
    {
        ArrayList PriceList = new ArrayList();
        public FormMassagePrice()
        {
            InitializeComponent();
            int PriceNumbers = 6;
            for (int i = 0; i < PriceNumbers; i++)
            {
                PriceList.Add(new 洗浴中心会员管理系统.UserControlPriceList());
                this.PanelPriceList.Controls.Add((UserControlPriceList)PriceList[i]);
                ((UserControlPriceList)PriceList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlPriceList)PriceList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlPriceList)PriceList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlPriceList)PriceList[i]).Name = "PriceList" + i;
                if (i % 2 == 0)
                    ((UserControlPriceList)PriceList[i]).BackColor = Color.FromArgb(25, 20, 25);
                ((UserControlPriceList)PriceList[i]).Controls["LabelID"].Text = (PriceNumbers - i).ToString();
            }
        }
    }
}