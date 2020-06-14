using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class FormDiscountCoupon : Form
    {
        public FormDiscountCoupon()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                if (Regex.IsMatch(TextBoxDiscount.Text, @"\d{1,2}") && Regex.IsMatch(TextBoxNumbers.Text, @"\d+"))
                {
                    SqlCommand AddDiscountCouponCmd = new SqlCommand("AddDiscountCoupon", GlobalClass.Connection);
                    AddDiscountCouponCmd.CommandType = CommandType.StoredProcedure;
                    AddDiscountCouponCmd.Parameters.Add("@Class", SqlDbType.VarChar, 8);
                    AddDiscountCouponCmd.Parameters.Add("@Discount", SqlDbType.Int);
                    AddDiscountCouponCmd.Parameters.Add("@HandlePerson", SqlDbType.Char, 6);
                    AddDiscountCouponCmd.Parameters.Add("@Numbers", SqlDbType.Int);
                    AddDiscountCouponCmd.Parameters[0].Value = LabelDiscountCoupon.Text;
                    AddDiscountCouponCmd.Parameters[1].Value = Convert.ToInt32(TextBoxDiscount.Text);
                    AddDiscountCouponCmd.Parameters[2].Value = GlobalClass.EmployeeNo;
                    AddDiscountCouponCmd.Parameters[3].Value = Convert.ToInt32(TextBoxNumbers.Text);
                    if (AddDiscountCouponCmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("添加成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("添加失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("输入不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxDiscount.Text = String.Empty;
                    TextBoxNumbers.Text = String.Empty;
                    TextBoxDiscount.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormDiscountCoupon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}