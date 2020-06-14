using System;
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
    public partial class FormMemberHandling : Form
    {
        int LastNo = new int();
        public FormMemberHandling()
        {
            InitializeComponent();
            if (GlobalClass.Connection.State == ConnectionState.Open)
                GlobalClass.Connection.Close();
            GlobalClass.Connection.Open();
            SqlCommand MemberHandlingCmd = new SqlCommand("select CardNo from Member order by CardNo desc", GlobalClass.Connection);
            SqlDataReader data = MemberHandlingCmd.ExecuteReader();
            while (data.Read())
            {
                int temp = Convert.ToInt32(data[0].ToString());
                if (temp > LastNo)
                    LastNo = temp;
            }
            this.TextBoxHandlePerson.Text = GlobalClass.EmployeeNo;
            TextBoxHandleDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            this.TextBoxRechargeAmount.Text = String.Empty;
            this.TextBoxRemark.Text = String.Empty;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxHandlePerson.Text != String.Empty && TextBoxHandleDate.Text != String.Empty &&
                TextBoxName.Text != String.Empty && (RadioButtonMan.Checked != false || RadioButtonWoman.Checked != false) &&
                TextBoxPassword.Text != String.Empty && TextBoxIDCardNo.Text != String.Empty && TextBoxTel.Text != String.Empty &&
                TextBoxAddress.Text != String.Empty && TextBoxRechargeAmount.Text != String.Empty)
            {
                try
                {
                    if (GlobalClass.Connection.State == ConnectionState.Open)
                        GlobalClass.Connection.Close();
                    GlobalClass.Connection.Open();
                    SqlCommand SubmitCmd = new SqlCommand("SubmitMemberHandle", GlobalClass.Connection);
                    SubmitCmd.CommandType = CommandType.StoredProcedure;
                    SubmitCmd.Parameters.Add("@CardNo", SqlDbType.NChar, 6);
                    SubmitCmd.Parameters.Add("@Password", SqlDbType.NChar, 32);
                    SubmitCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 8);
                    SubmitCmd.Parameters.Add("@Sex", SqlDbType.NChar, 2);
                    SubmitCmd.Parameters.Add("@IDCardNo", SqlDbType.NChar, 18);
                    SubmitCmd.Parameters.Add("@Tel", SqlDbType.NChar, 11);
                    SubmitCmd.Parameters.Add("@Address", SqlDbType.NVarChar, 32);
                    SubmitCmd.Parameters.Add("@HandleDate", SqlDbType.Date);
                    SubmitCmd.Parameters.Add("@HandlePerson", SqlDbType.Char, 6);
                    SubmitCmd.Parameters.Add("@Balance", SqlDbType.Int);
                    SubmitCmd.Parameters.Add("@Remark", SqlDbType.Text);
                    SubmitCmd.Parameters[0].Value = (LastNo + 1).ToString() /*TempRef.Text.Substring(7)*/;
                    SubmitCmd.Parameters[1].Value = GlobalClass.MD5(TextBoxPassword.Text);
                    SubmitCmd.Parameters[2].Value = TextBoxName.Text;
                    if (RadioButtonMan.Checked == true)
                        SubmitCmd.Parameters[3].Value = "男";
                    else
                        SubmitCmd.Parameters[3].Value = "女";
                    SubmitCmd.Parameters[4].Value = TextBoxIDCardNo.Text;
                    SubmitCmd.Parameters[5].Value = TextBoxTel.Text;
                    SubmitCmd.Parameters[6].Value = TextBoxAddress.Text;
                    SubmitCmd.Parameters[7].Value = TextBoxHandleDate.Text;
                    SubmitCmd.Parameters[8].Value = TextBoxHandlePerson.Text;
                    SubmitCmd.Parameters[9].Value = TextBoxRechargeAmount.Text;
                    SubmitCmd.Parameters[10].Value = TextBoxRemark.Text;
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