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
        /// <summary>
        /// 在构造函数中调用CustomizeDesing函数，将所有子面板收缩起来。
        /// </summary>
        private void CustomizeDesing()
        {
            PanelMemberManagement.Visible = false;
            PanelEmployeeManagement.Visible = false;
            PanelPriceManagement.Visible = false;
        }
        /// <summary>
        /// 将所有子面板收缩起来。
        /// </summary>
        private void HideSubMenu()
        {
            if (PanelMemberManagement.Visible == true)
                PanelMemberManagement.Visible = false;
            if (PanelEmployeeManagement.Visible == true)
                PanelEmployeeManagement.Visible = false;
            if (PanelPriceManagement.Visible == true)
                PanelPriceManagement.Visible = false;
        }
        /// <summary>
        /// 打开点击的子面板，其它面板收缩起来，再次点击收缩此面板。
        /// </summary>
        /// <param name="SubMenu"></param>
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
            PanelChildForm.Controls.Add(ChildForm);
            PanelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        #endregion

        private void ButtonSettleAccounts_Click(object sender, EventArgs e)
        {
            //需要进行权限判断
            HideSubMenu();
            OpenChildForm(new FormSettleAccounts());
        }

        private void ButtonMemberManagement_Click(object sender, EventArgs e)
        {
            //需要进行权限判断
            ShowSubMenu(PanelMemberManagement);
        }

        private void ButtonMemberInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMemberInformation());
        }

        private void ButtonMemberHandling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMemberHandling());
        }

        private void ButtonMemberRecharge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMemberRecharge());
        }

        private void ButtonEmployeeManagement_Click(object sender, EventArgs e)
        {
            //需要进行权限判断
            ShowSubMenu(PanelEmployeeManagement);
        }

        private void ButtonEmployeeInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEmployeeInformation());
        }

        private void ButtonEntryHandling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEntryHandling());
        }

        private void ButtonSalaryHandling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSalaryHandling());
        }

        private void ButtonPriceManagement_Click(object sender, EventArgs e)
        {
            //需要进行权限判断
            ShowSubMenu(PanelPriceManagement);
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
            //需要进行权限判断
            HideSubMenu();
            OpenChildForm(new FormMaterialManagement());
        }

        private void ButtonCouponIssue_Click(object sender, EventArgs e)
        {
            //需要进行权限判断
            HideSubMenu();
            OpenChildForm(new FormCouponIssue());
        }

        private void ButtonDataReport_Click(object sender, EventArgs e)
        {
            //需要进行权限判断
            HideSubMenu();
            OpenChildForm(new FormDataReport());
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}