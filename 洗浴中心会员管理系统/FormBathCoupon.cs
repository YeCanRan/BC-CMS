using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 洗浴中心会员管理系统
{
    public partial class FormBathCoupon : Form
    {
        public FormBathCoupon()
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
                SqlCommand AddBathCouponCmd = new SqlCommand("AddBathCoupon", GlobalClass.Connection);
                AddBathCouponCmd.CommandType = CommandType.StoredProcedure;
                AddBathCouponCmd.Parameters.Add("@Class", SqlDbType.VarChar, 8);
                AddBathCouponCmd.Parameters.Add("@HandlePerson", SqlDbType.Char, 6);
                AddBathCouponCmd.Parameters.Add("@Numbers", SqlDbType.Int);
                AddBathCouponCmd.Parameters[0].Value = LabelBathCoupon.Text;
                AddBathCouponCmd.Parameters[1].Value = GlobalClass.EmployeeNo;
                AddBathCouponCmd.Parameters[2].Value = Convert.ToInt32(TextBoxNumbers.Text);
                if (AddBathCouponCmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("添加成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
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
        private void FormBathCoupon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}