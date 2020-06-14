using System;
using System.Collections;
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
    public partial class FormMaterialManagement : Form
    {
        ArrayList MaterialList = new ArrayList();
        int i = 0;
        public FormMaterialManagement()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand MaterialCmd = new SqlCommand("select * from ViewItem", GlobalClass.Connection);
                SqlDataReader data = MaterialCmd.ExecuteReader();
                while (data.Read())
                {
                    MaterialList.Add(new 洗浴中心会员管理系统.UserControlMaterialList());
                    this.PanelMaterialList.Controls.Add((UserControlMaterialList)MaterialList[i]);
                    this.PanelMaterialList.Controls.SetChildIndex((UserControlMaterialList)MaterialList[i], 0);
                    ((UserControlMaterialList)MaterialList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlMaterialList)MaterialList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlMaterialList)MaterialList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlMaterialList)MaterialList[i]).Name = "MaterialList" + i;
                    ((UserControlMaterialList)MaterialList[i]).Controls["LabelID"].Text = (i + 1).ToString();
                    if (i % 2 == 0)
                        ((UserControlMaterialList)MaterialList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlMaterialList)MaterialList[i]).Controls["LabelName"].Text = data[0].ToString();
                    ((UserControlMaterialList)MaterialList[i]).Controls["LabelTotalReserves"].Text = data[1].ToString();
                    ((UserControlMaterialList)MaterialList[i]).Controls["LabelCurrentReserve"].Text = data[2].ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
                ((UserControlMaterialList)MaterialList[j]).Controls["TextBoxIncrement"].Text = String.Empty;
        }
    }
}