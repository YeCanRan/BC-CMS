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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        #region 自定义的函数
        //在构造函数中调用CustomizeDesing函数，将所有子面板收缩起来。
        private void CustomizeDesing()
        {
            PanelMemberManagement.Visible = false;
            PanelEmployeeManagement.Visible = false;
            PanelPriceManagement.Visible = false;
        }

        //将所有子面板收缩起来。
        private void HideSubMenu()
        {
            if (PanelMemberManagement.Visible == true)
                PanelMemberManagement.Visible = false;
            if (PanelEmployeeManagement.Visible == true)
                PanelEmployeeManagement.Visible = false;
            if (PanelPriceManagement.Visible == true)
                PanelPriceManagement.Visible = false;
        }
        //打开点击的子面板，其它面板收缩起来，再次点击收缩此面板。
        private void ShowSubMenu(Panel SubMenu)
        {
            if (!SubMenu.Visible)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        /// <summary>
        /// 在主菜单的右侧显示子窗口。
        /// </summary>
        /// <param name="ChildForm"></param>
        private void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            //ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Clear();
            PanelChildForm.Controls.Add(ChildForm);
            PanelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        #endregion

        private void ButtonSettleAccounts_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、店长、经理和前台可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    HideSubMenu();
                    OpenChildForm(new FormSettleAccounts());
                    break;
                case (int)GlobalClass.Privilege.Director:
                    HideSubMenu();
                    OpenChildForm(new FormSettleAccounts());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    HideSubMenu();
                    OpenChildForm(new FormSettleAccounts());
                    break;
                case (int)GlobalClass.Privilege.Reception:
                    HideSubMenu();
                    OpenChildForm(new FormSettleAccounts());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonMemberManagement_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、店长、经理和前台可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    ShowSubMenu(PanelMemberManagement);
                    break;
                case (int)GlobalClass.Privilege.Director:
                    ShowSubMenu(PanelMemberManagement);
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    ShowSubMenu(PanelMemberManagement);
                    break;
                case (int)GlobalClass.Privilege.Reception:
                    ShowSubMenu(PanelMemberManagement);
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonMemberInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMemberInformation());
        }

        private void ButtonMemberHandling_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、经理和前台可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    OpenChildForm(new FormMemberHandling());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    OpenChildForm(new FormMemberHandling());
                    break;
                case (int)GlobalClass.Privilege.Reception:
                    OpenChildForm(new FormMemberHandling());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonMemberRecharge_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、经理和前台可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    OpenChildForm(new FormMemberRecharge());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    OpenChildForm(new FormMemberRecharge());
                    break;
                case (int)GlobalClass.Privilege.Reception:
                    OpenChildForm(new FormMemberRecharge());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonEmployeeManagement_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、店长和经理可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    ShowSubMenu(PanelEmployeeManagement);
                    break;
                case (int)GlobalClass.Privilege.Director:
                    ShowSubMenu(PanelEmployeeManagement);
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    ShowSubMenu(PanelEmployeeManagement);
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonEmployeeInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEmployeeInformation());
        }

        private void ButtonEntryHandling_Click(object sender, EventArgs e)
        {
            //权限判断,管理员和经理可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    OpenChildForm(new FormEntryHandling());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    OpenChildForm(new FormEntryHandling());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonSalaryHandling_Click(object sender, EventArgs e)
        {
            //权限判断,管理员和经理可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    OpenChildForm(new FormSalaryHandling());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    OpenChildForm(new FormSalaryHandling());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonPriceManagement_Click(object sender, EventArgs e)
        {
            //权限判断,管理员和经理可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    ShowSubMenu(PanelPriceManagement);
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    ShowSubMenu(PanelPriceManagement);
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonBasicConsumption_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBasicConsumption());
        }

        private void ButtonBathPrice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBathPrice());
        }

        private void ButtonMassagePrice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMassagePrice());
        }

        private void ButtonTeaPrice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTeaPrice());
        }

        private void ButtonOvernightPrice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOvernightPrice());
        }

        private void ButtonMaterialManagement_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、经理和后勤可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    HideSubMenu();
                    OpenChildForm(new FormMaterialManagement());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    HideSubMenu();
                    OpenChildForm(new FormMaterialManagement());
                    break;
                case (int)GlobalClass.Privilege.Logistics:
                    HideSubMenu();
                    OpenChildForm(new FormMaterialManagement());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonCouponIssue_Click(object sender, EventArgs e)
        {
            //权限判断,管理员和经理可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    HideSubMenu();
                    OpenChildForm(new FormCouponIssue());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    HideSubMenu();
                    OpenChildForm(new FormCouponIssue());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonDataReport_Click(object sender, EventArgs e)
        {
            //权限判断,管理员、店长和经理可以打开，其他的都不可以。
            switch (GlobalClass.PrivilegeLevel)
            {
                case (int)GlobalClass.Privilege.Administrator:
                    HideSubMenu();
                    OpenChildForm(new FormDataReport());
                    break;
                case (int)GlobalClass.Privilege.Director:
                    HideSubMenu();
                    OpenChildForm(new FormDataReport());
                    break;
                case (int)GlobalClass.Privilege.Manager:
                    HideSubMenu();
                    OpenChildForm(new FormDataReport());
                    break;
                default:
                    MessageBox.Show("权限不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}