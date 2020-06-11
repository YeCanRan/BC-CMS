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
    public partial class FormLeaflet : Form
    {
        public FormLeaflet()
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
                SqlCommand AddLeafletCmd = new SqlCommand("AddLeaflet", GlobalClass.Connection);
                AddLeafletCmd.CommandType = CommandType.StoredProcedure;
                AddLeafletCmd.Parameters.Add("@Class", SqlDbType.VarChar, 8);
                AddLeafletCmd.Parameters.Add("@HandlePerson", SqlDbType.Char, 6);
                AddLeafletCmd.Parameters.Add("@Numbers", SqlDbType.Int);
                AddLeafletCmd.Parameters[0].Value = LabelLeaflet.Text;
                AddLeafletCmd.Parameters[1].Value = GlobalClass.EmployeeNo;
                AddLeafletCmd.Parameters[2].Value = Convert.ToInt32(TextBoxNumbers.Text);
                if (AddLeafletCmd.ExecuteNonQuery() == 1)
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
        private void FormLeaflet_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}