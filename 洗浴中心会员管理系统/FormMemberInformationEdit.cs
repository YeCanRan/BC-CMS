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
    public partial class FormMemberInformationEdit : Form
    {
        Label TempRef;
        public FormMemberInformationEdit(Label MemberNo)
        {
            InitializeComponent();
            TempRef = MemberNo;
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand MemberInformation = new SqlCommand("select * from ViewMemberInformationEdit where CardNo=" + MemberNo.Text.Substring(7), GlobalClass.Connection);
                SqlDataReader data = MemberInformation.ExecuteReader();
                data.Read();
                this.TextBoxHandlePerson.Text = data[8].ToString();
                this.TextBoxHandleDate.Text = data[7].ToString().Substring(0, 9);
                this.TextBoxName.Text = data[2].ToString();
                if (data[3].ToString() == "男")
                {
                    RadioButtonMan.Checked = true;
                    RadioButtonWoman.Checked = false;
                }
                else
                {
                    RadioButtonMan.Checked = false;
                    RadioButtonWoman.Checked = true;
                }
                this.TextBoxIDCardNo.Text = data[4].ToString();
                this.TextBoxTel.Text = data[5].ToString();
                this.TextBoxAddress.Text = data[6].ToString();
                this.TextBoxBalance.Text = data[9].ToString();
                this.TextBoxRemark.Text = data[10].ToString();
                data.Close();
                GlobalClass.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxHandlePerson.Text = String.Empty;
            this.TextBoxHandleDate.Text = String.Empty;
            this.TextBoxName.Text = String.Empty;
            this.RadioButtonMan.Checked = false;
            this.RadioButtonWoman.Checked = false;
            this.TextBoxPassword.Text = String.Empty;
            this.TextBoxIDCardNo.Text = String.Empty;
            this.TextBoxTel.Text = String.Empty;
            this.TextBoxAddress.Text = String.Empty;
            this.TextBoxBalance.Text = String.Empty;
            this.TextBoxRemark.Text = String.Empty;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxHandlePerson.Text != String.Empty && TextBoxHandleDate.Text != String.Empty &&
                TextBoxName.Text != String.Empty && (RadioButtonMan.Checked != false || RadioButtonWoman.Checked != false) &&
                TextBoxPassword.Text != String.Empty && TextBoxIDCardNo.Text != String.Empty && TextBoxTel.Text != String.Empty &&
                TextBoxAddress.Text != String.Empty && TextBoxBalance.Text != String.Empty /*&& TextBoxRemark.Text != String.Empty*/)
            {
                try
                {
                    if (GlobalClass.Connection.State == ConnectionState.Open)
                        GlobalClass.Connection.Close();
                    GlobalClass.Connection.Open();
                    SqlCommand SubmitCmd = new SqlCommand("SubmitMemberEdit", GlobalClass.Connection);
                    SubmitCmd.CommandType = CommandType.StoredProcedure;
                    SubmitCmd.Parameters.Add("@CardNo", SqlDbType.NChar, 6);
                    SubmitCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 8);
                    SubmitCmd.Parameters.Add("@Password", SqlDbType.NChar, 32);
                    SubmitCmd.Parameters.Add("@Sex", SqlDbType.NChar, 2);
                    SubmitCmd.Parameters.Add("@IDCardNo", SqlDbType.NChar, 18);
                    SubmitCmd.Parameters.Add("@Tel", SqlDbType.NChar, 11);
                    SubmitCmd.Parameters.Add("@Address", SqlDbType.VarChar, 32);
                    SubmitCmd.Parameters.Add("@Balance", SqlDbType.Int);
                    SubmitCmd.Parameters.Add("@Remark", SqlDbType.Text);
                    SubmitCmd.Parameters[0].Value = TempRef.Text.Substring(7);
                    SubmitCmd.Parameters[1].Value = TextBoxName.Text;
                    SubmitCmd.Parameters[2].Value = GlobalClass.MD5(TextBoxPassword.Text);
                    if (RadioButtonMan.Checked == true)
                        SubmitCmd.Parameters[3].Value = "男";
                    else
                        SubmitCmd.Parameters[3].Value = "女";
                    SubmitCmd.Parameters[4].Value = TextBoxIDCardNo.Text;
                    SubmitCmd.Parameters[5].Value = TextBoxTel.Text;
                    SubmitCmd.Parameters[6].Value = TextBoxAddress.Text;
                    SubmitCmd.Parameters[7].Value = TextBoxBalance.Text;
                    SubmitCmd.Parameters[8].Value = TextBoxRemark.Text;
                    if (SubmitCmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("提交成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("提交失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GlobalClass.Connection.Close();
                }
            }
            else
            {
                MessageBox.Show("信息不完整!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}