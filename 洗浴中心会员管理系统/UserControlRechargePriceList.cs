﻿using System;
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
    public partial class UserControlRechargePriceList : UserControl
    {
        Label TempRef;
        public UserControlRechargePriceList(Label LabelPrice)
        {
            InitializeComponent();
            TempRef = LabelPrice;
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            TempRef.Text = (Convert.ToInt32(this.LabelRechargePrice.Text) + Convert.ToInt32(this.LabelGiftPrice.Text)).ToString();
        }
    }
}