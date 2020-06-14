using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int i = 0;
        public FormCouponIssue()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand CouponIssue = new SqlCommand("select * from ViewCoupon", GlobalClass.Connection);
                SqlDataReader data = CouponIssue.ExecuteReader();
                while (data.Read())
                {
                    CouponList.Add(new 洗浴中心会员管理系统.UserControlCouponList());
                    this.PanelCouponList.Controls.Add((UserControlCouponList)CouponList[i]);
                    this.PanelCouponList.Controls.SetChildIndex((UserControlCouponList)CouponList[i], 0);
                    ((UserControlCouponList)CouponList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlCouponList)CouponList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlCouponList)CouponList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlCouponList)CouponList[i]).Name = "CouponList" + i;
                    if (i % 2 == 0)
                        ((UserControlCouponList)CouponList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlCouponList)CouponList[i]).Controls["LabelID"].Text = data[0].ToString();
                    ((UserControlCouponList)CouponList[i]).Controls["LabelClass"].Text = data[1].ToString();
                    ((UserControlCouponList)CouponList[i]).Controls["LabelDiscount"].Text = data[2].ToString();
                    ((UserControlCouponList)CouponList[i]).Controls["LabelEquivalent"].Text = data[3].ToString();
                    ((UserControlCouponList)CouponList[i]).Controls["LabelNumbers"].Text = data[4].ToString();
                    ((UserControlCouponList)CouponList[i]).Controls["LabelEmpNo"].Text = data[5].ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void ButtonAddLeaflet_Click(object sender, EventArgs e)
        {
            new FormLeaflet().Show();
        }

        private void ButtonAddBathCoupon_Click(object sender, EventArgs e)
        {
            new FormBathCoupon().Show();
        }

        private void ButtonAddDiscountCoupon_Click(object sender, EventArgs e)
        {
            new FormDiscountCoupon().Show();
        }

        private void ButtonAddCashCoupon_Click(object sender, EventArgs e)
        {
            new FormCashCoupon().Show();
        }
    }
}