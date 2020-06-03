using System;
using System.Collections;
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
    public partial class FormMaterialManagement : Form
    {
        ArrayList MaterialList = new ArrayList();
        public FormMaterialManagement()
        {
            InitializeComponent();
            int MaterialNumbers = 9;
            for (int i = 0; i < MaterialNumbers; i++)
            {
                MaterialList.Add(new 洗浴中心会员管理系统.UserControlMaterialList());
                this.PanelMaterialList.Controls.Add((UserControlMaterialList)MaterialList[i]);
                ((UserControlMaterialList)MaterialList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlMaterialList)MaterialList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlMaterialList)MaterialList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlMaterialList)MaterialList[i]).Name = "MaterialList" + i;
                if (i % 2 == 0)
                    ((UserControlMaterialList)MaterialList[i]).BackColor = Color.FromArgb(25, 20, 25);
                ((UserControlMaterialList)MaterialList[i]).Controls["LabelID"].Text = (MaterialNumbers - i).ToString();
            }
        }
    }
}