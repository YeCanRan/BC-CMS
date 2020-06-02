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
    public partial class FormSettleAccounts : Form
    {
        ArrayList ConsumerList = new ArrayList();
        public FormSettleAccounts()
        {
            InitializeComponent();

            int ConsumerNumbers = 30;
            for (int i = 0; i < ConsumerNumbers; i++)
            {
                ConsumerList.Add(new 洗浴中心会员管理系统.UserControlConsumerList());
                this.PanelConsumerList.Controls.Add((UserControlConsumerList)ConsumerList[i]);
                ((UserControlConsumerList)ConsumerList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlConsumerList)ConsumerList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlConsumerList)ConsumerList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlConsumerList)ConsumerList[i]).Name = "ConsumerList" + i;
                if (i % 2 == 0)
                {
                    ((UserControlConsumerList)ConsumerList[i]).BackColor = Color.FromArgb(25, 20, 25);
                }
                else
                {
                    ((UserControlConsumerList)ConsumerList[i]).BackColor = Color.FromArgb(35, 30, 35);
                }
            }
            //this.PanelConsumerList.ResumeLayout(false);
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }
    }
}