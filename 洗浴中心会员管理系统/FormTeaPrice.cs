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
    public partial class FormTeaPrice : Form
    {
        ArrayList PriceList = new ArrayList();
        int i = 0;
        public FormTeaPrice()
        {
            InitializeComponent();
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand PriceChange = new SqlCommand("select * from ViewPrice where Class='茶水'", GlobalClass.Connection);
                SqlDataReader data = PriceChange.ExecuteReader();
                while (data.Read())
                {
                    PriceList.Add(new 洗浴中心会员管理系统.UserControlPriceList());
                    this.PanelPriceList.Controls.Add((UserControlPriceList)PriceList[i]);
                    this.PanelPriceList.Controls.SetChildIndex((UserControlPriceList)PriceList[i], 0);
                    ((UserControlPriceList)PriceList[i]).Size = new System.Drawing.Size(1014, 58);
                    ((UserControlPriceList)PriceList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                    ((UserControlPriceList)PriceList[i]).Location = new System.Drawing.Point(0, 58 * i);
                    ((UserControlPriceList)PriceList[i]).Name = "PriceList" + i;
                    if (i % 2 == 0)
                        ((UserControlPriceList)PriceList[i]).BackColor = Color.FromArgb(25, 20, 25);
                    ((UserControlPriceList)PriceList[i]).Controls["LabelID"].Text = (i + 1).ToString();
                    ((UserControlPriceList)PriceList[i]).Controls["LabelName"].Text = data[0].ToString();
                    ((UserControlPriceList)PriceList[i]).Controls["TextBoxOriginalPrice"].Text = data[2].ToString();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
            /*int PriceNumbers = 9;
            for (int i = 0; i < PriceNumbers; i++)
            {
                PriceList.Add(new 洗浴中心会员管理系统.UserControlPriceList());
                this.PanelPriceList.Controls.Add((UserControlPriceList)PriceList[i]);
                ((UserControlPriceList)PriceList[i]).Size = new System.Drawing.Size(1014, 58);
                ((UserControlPriceList)PriceList[i]).Dock = System.Windows.Forms.DockStyle.Top;
                ((UserControlPriceList)PriceList[i]).Location = new System.Drawing.Point(0, 58 * i);
                ((UserControlPriceList)PriceList[i]).Name = "PriceList" + i;
                if (i % 2 == 0)
                    ((UserControlPriceList)PriceList[i]).BackColor = Color.FromArgb(25, 20, 25);
                ((UserControlPriceList)PriceList[i]).Controls["LabelID"].Text = (PriceNumbers - i).ToString();
            }*/
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                ((UserControlPriceList)PriceList[j]).Controls["TextBoxPresentPrice"].Text = String.Empty;
            }
        }
    }
}