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
    public partial class FormEntryHandling : Form
    {
        int LastNo = new int();
        public FormEntryHandling()
        {
            InitializeComponent();
            this.ComboBoxPrivilegeLevel.Items.Add(String.Empty);
            this.ComboBoxPrivilegeLevel.Items.Add("1");
            this.ComboBoxPrivilegeLevel.Items.Add("2");
            this.ComboBoxPrivilegeLevel.Items.Add("3");
            this.ComboBoxPrivilegeLevel.Items.Add("4");
            this.ComboBoxPrivilegeLevel.Items.Add("5");
            this.ComboBoxClass.Items.Add(String.Empty);
            this.ComboBoxClass.Items.Add("店长");
            this.ComboBoxClass.Items.Add("经理");
            this.ComboBoxClass.Items.Add("前台");
            this.ComboBoxClass.Items.Add("后勤");
            this.ComboBoxClass.Items.Add("鞋管");
            this.ComboBoxClass.Items.Add("衣管");
            this.ComboBoxClass.Items.Add("服务员");
            this.ComboBoxClass.Items.Add("艺妓");
            this.ComboBoxClass.Items.Add("安保");
            this.ComboBoxClass.Items.Add("保洁");
            this.ComboBoxShift.Items.Add(String.Empty);
            this.ComboBoxShift.Items.Add("日班");
            this.ComboBoxShift.Items.Add("夜班");
            this.ComboBoxMaritalStatus.Items.Add(String.Empty);
            this.ComboBoxMaritalStatus.Items.Add("已婚");
            this.ComboBoxMaritalStatus.Items.Add("未婚");
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand MemberHandlingCmd = new SqlCommand("select No from Employee order by No desc", GlobalClass.Connection);
                SqlDataReader data = MemberHandlingCmd.ExecuteReader();
                while (data.Read())
                {
                    int temp = Convert.ToInt32(data[0].ToString());
                    if (temp > LastNo)
                        LastNo = temp;
                }
                TextBoxDateOfEmployment.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxName.Text = String.Empty;
            this.RadioButtonMan.Checked = false;
            this.RadioButtonWoman.Checked = false;
            this.TextBoxPassword.Text = String.Empty;
            this.ComboBoxPrivilegeLevel.SelectedIndex = 0;
            this.TextBoxPolitical.Text = String.Empty;
            this.ComboBoxClass.SelectedIndex = 0;
            this.TextBoxBirthDay.Text = String.Empty;
            this.TextBoxIDCardNo.Text = String.Empty;
            this.TextBoxNation.Text = String.Empty;
            this.TextBoxNativePlace.Text = String.Empty;
            this.TextBoxTel.Text = String.Empty;
            this.TextBoxAddress.Text = String.Empty;
            this.ComboBoxShift.SelectedIndex = 0;
            this.TextBoxSalary.Text = String.Empty;
            this.TextBoxBankCardNo.Text = String.Empty;
            this.ComboBoxMaritalStatus.SelectedIndex = 0;
            this.TextBoxDateOfEmployment.Text = String.Empty;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text != String.Empty && (RadioButtonMan.Checked != false || RadioButtonWoman.Checked != false) && TextBoxPassword.Text != String.Empty && ComboBoxPrivilegeLevel.SelectedIndex != 0 &&
                TextBoxPolitical.Text != String.Empty && ComboBoxClass.SelectedIndex != 0 && TextBoxBirthDay.Text != String.Empty && TextBoxIDCardNo.Text != String.Empty && TextBoxNation.Text != String.Empty &&
                TextBoxNativePlace.Text != String.Empty && TextBoxTel.Text != String.Empty && TextBoxAddress.Text != String.Empty && ComboBoxShift.SelectedIndex != 0 && TextBoxSalary.Text != String.Empty &&
                TextBoxBankCardNo.Text != String.Empty && ComboBoxMaritalStatus.SelectedIndex != 0 && TextBoxDateOfEmployment.Text != String.Empty)
            {
                try
                {
                    if (GlobalClass.Connection.State == ConnectionState.Open)
                        GlobalClass.Connection.Close();
                    GlobalClass.Connection.Open();
                    SqlCommand SubmitCmd = new SqlCommand("SubmitEntryHandle", GlobalClass.Connection);
                    SubmitCmd.CommandType = CommandType.StoredProcedure;
                    SubmitCmd.Parameters.Add("@No", SqlDbType.NChar, 6);
                    SubmitCmd.Parameters.Add("@Password", SqlDbType.NChar, 32);
                    SubmitCmd.Parameters.Add("@Name", SqlDbType.VarChar, 8);
                    SubmitCmd.Parameters.Add("@Sex", SqlDbType.NChar, 2);
                    SubmitCmd.Parameters.Add("@Nation", SqlDbType.VarChar, 8);
                    SubmitCmd.Parameters.Add("@NativePlace", SqlDbType.VarChar, 16);
                    SubmitCmd.Parameters.Add("@Political", SqlDbType.VarChar, 8);
                    SubmitCmd.Parameters.Add("@Class", SqlDbType.VarChar, 8);
                    SubmitCmd.Parameters.Add("@Shift", SqlDbType.Int);
                    SubmitCmd.Parameters.Add("@Salary", SqlDbType.Int);
                    SubmitCmd.Parameters.Add("@Tel", SqlDbType.NChar, 11);
                    SubmitCmd.Parameters.Add("@Address", SqlDbType.VarChar, 32);
                    SubmitCmd.Parameters.Add("@PrivilegeLevel", SqlDbType.Int);
                    SubmitCmd.Parameters.Add("@IDCardNo", SqlDbType.NChar, 18);
                    SubmitCmd.Parameters.Add("@BankCardNo", SqlDbType.NChar, 19);
                    SubmitCmd.Parameters.Add("@BirthDay", SqlDbType.Date);
                    SubmitCmd.Parameters.Add("@MaritalStatus", SqlDbType.Int);
                    SubmitCmd.Parameters.Add("@DateOfEmployment", SqlDbType.Date);
                    SubmitCmd.Parameters[0].Value = (LastNo+1).ToString();
                    SubmitCmd.Parameters[1].Value = GlobalClass.MD5(TextBoxPassword.Text);
                    SubmitCmd.Parameters[2].Value = TextBoxName.Text;
                    if (RadioButtonMan.Checked == true)
                        SubmitCmd.Parameters[3].Value = "男";
                    else
                        SubmitCmd.Parameters[3].Value = "女";
                    SubmitCmd.Parameters[4].Value = TextBoxNation.Text;
                    SubmitCmd.Parameters[5].Value = TextBoxNativePlace.Text;
                    SubmitCmd.Parameters[6].Value = TextBoxPolitical.Text;
                    SubmitCmd.Parameters[7].Value = ComboBoxClass.Text;
                    if (ComboBoxShift.Text == "日班")
                        SubmitCmd.Parameters[8].Value = 0;
                    else if (ComboBoxShift.Text == "夜班")
                        SubmitCmd.Parameters[8].Value = 1;
                    SubmitCmd.Parameters[9].Value = TextBoxSalary.Text;
                    SubmitCmd.Parameters[10].Value = TextBoxTel.Text;
                    SubmitCmd.Parameters[11].Value = TextBoxAddress.Text;
                    SubmitCmd.Parameters[12].Value = ComboBoxPrivilegeLevel.Text;
                    SubmitCmd.Parameters[13].Value = TextBoxIDCardNo.Text;
                    SubmitCmd.Parameters[14].Value = TextBoxBankCardNo.Text;
                    SubmitCmd.Parameters[15].Value = TextBoxBirthDay.Text;
                    if (ComboBoxMaritalStatus.Text == "未婚")
                        SubmitCmd.Parameters[16].Value = 0;
                    else if (ComboBoxMaritalStatus.Text == "已婚")
                        SubmitCmd.Parameters[16].Value = 1;
                    SubmitCmd.Parameters[17].Value = TextBoxDateOfEmployment.Text;
                    if (SubmitCmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("提交成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("提交失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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