using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.PanelProgressBar.Width = 0;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //...
            this.TimerProgressBar.Start();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerProgressBar_Tick(object sender, EventArgs e)
        {
            this.PanelProgressBar.Width += 15;
            if (this.PanelProgressBar.Width >= this.PanelProgressBarContainer.Width)
            {
                this.TimerProgressBar.Stop();
                this.DialogResult = DialogResult.OK;
            };
        }
    }
}