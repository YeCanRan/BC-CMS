using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                GlobalClass.StrCnn = System.Configuration.ConfigurationManager.ConnectionStrings["StrCnn"].ConnectionString.ToString();
                GlobalClass.Connection.ConnectionString = GlobalClass.StrCnn;
                TextBoxAccount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TextBoxAccount.Text, @"1\d{5}"))
            {
                MessageBox.Show("用户名不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxAccount.Clear();
                TextBoxAccount.Focus();
            }
            else if (TextBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("密码不合法!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxPassword.Clear();
                TextBoxPassword.Focus();
            }
            else
            {
                try
                {
                    GlobalClass.Connection.Open();
                    SqlCommand LoginCmd = new SqlCommand("UserLogin", GlobalClass.Connection);
                    LoginCmd.CommandType = CommandType.StoredProcedure;
                    LoginCmd.Parameters.Add("@No", SqlDbType.NChar, 6);
                    LoginCmd.Parameters.Add("@Password", SqlDbType.NChar, 32);
                    LoginCmd.Parameters.Add("@ReturnValue", SqlDbType.Int, 6);
                    LoginCmd.Parameters[0].Value = TextBoxAccount.Text;
                    LoginCmd.Parameters[1].Value = GlobalClass.MD5(TextBoxPassword.Text);
                    LoginCmd.Parameters[2].Direction = ParameterDirection.ReturnValue;
                    LoginCmd.ExecuteNonQuery();
                    int ReturnValue = (int)LoginCmd.Parameters[2].Value;
                    GlobalClass.Connection.Close();
                    if (ReturnValue == 0)
                    {
                        GlobalClass.UserName = TextBoxAccount.Text;
                        GlobalClass.EmployeeNo = TextBoxAccount.Text;
                        GlobalClass.PrivilegeLevel = (int)GlobalClass.Privilege.Administrator;
                        this.TimerProgressBar.Start();
                    }
                    else if (ReturnValue == 1)
                    {
                        GlobalClass.UserName = TextBoxAccount.Text;
                        GlobalClass.EmployeeNo = TextBoxAccount.Text;
                        GlobalClass.PrivilegeLevel = (int)GlobalClass.Privilege.Director;
                        this.TimerProgressBar.Start();
                    }
                    else if (ReturnValue == 2)
                    {
                        GlobalClass.UserName = TextBoxAccount.Text;
                        GlobalClass.EmployeeNo = TextBoxAccount.Text;
                        GlobalClass.PrivilegeLevel = (int)GlobalClass.Privilege.Manager;
                        this.TimerProgressBar.Start();
                    }
                    else if (ReturnValue == 3)
                    {
                        GlobalClass.UserName = TextBoxAccount.Text;
                        GlobalClass.EmployeeNo = TextBoxAccount.Text;
                        GlobalClass.PrivilegeLevel = (int)GlobalClass.Privilege.Reception;
                        this.TimerProgressBar.Start();
                    }
                    else if (ReturnValue == 4)
                    {
                        GlobalClass.UserName = TextBoxAccount.Text;
                        GlobalClass.EmployeeNo = TextBoxAccount.Text;
                        GlobalClass.PrivilegeLevel = (int)GlobalClass.Privilege.Logistics;
                        this.TimerProgressBar.Start();
                    }
                    else if (ReturnValue == 5)
                    {
                        MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxAccount.Clear();
                        TextBoxPassword.Clear();
                        TextBoxAccount.Focus();
                    }
                    else if (ReturnValue == 6)
                    {
                        MessageBox.Show("密码错误!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxPassword.Clear();
                        TextBoxPassword.Focus();
                    }
                    else if (ReturnValue == 7)
                    {
                        MessageBox.Show("用户名错误!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxAccount.Clear();
                        TextBoxAccount.Focus();
                    }
                    else
                    {
                        MessageBox.Show("未知错误!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GlobalClass.Connection.Close();
                }
            }
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

        private void TextBoxAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TextBoxPassword.Focus();
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonLogin_Click(sender, e);
        }
    }
}