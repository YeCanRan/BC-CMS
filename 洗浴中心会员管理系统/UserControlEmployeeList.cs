﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 洗浴中心会员管理系统
{
    public partial class UserControlEmployeeList : UserControl
    {
        public UserControlEmployeeList()
        {
            InitializeComponent();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            FormEmployeeInformationEdit Edit = new FormEmployeeInformationEdit(this.LabelEmployeeNo);
            Edit.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此员工?", "消息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    if (GlobalClass.Connection.State == ConnectionState.Open)
                        GlobalClass.Connection.Close();
                    GlobalClass.Connection.Open();
                    SqlCommand DeleteEmployeeCmd = new SqlCommand("EmployeeDelete", GlobalClass.Connection);
                    DeleteEmployeeCmd.CommandType = CommandType.StoredProcedure;
                    DeleteEmployeeCmd.Parameters.Add("@No", SqlDbType.NChar, 6);
                    DeleteEmployeeCmd.Parameters[0].Value = LabelEmployeeNo.Text.ToString();
                    if (DeleteEmployeeCmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("删除成功,请刷新页面!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("删除失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GlobalClass.Connection.Close();
                }
            }
        }
    }
}