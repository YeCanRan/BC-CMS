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
    public partial class FormDataReport : Form
    {
        public FormDataReport()
        {
            InitializeComponent();
        }

        private void FormDataReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalClass.Connection.State == ConnectionState.Open)
                    GlobalClass.Connection.Close();
                GlobalClass.Connection.Open();
                SqlCommand QueryCmd = new SqlCommand("select * from ViewConsumerNumbers", GlobalClass.Connection);
                SqlDataReader data1 = QueryCmd.ExecuteReader();
                data1.Read();
                ChartConsumerNumbers.Series[0].Points.AddXY(1, 500-Convert.ToInt32(data1[0].ToString()));
                ChartConsumerNumbers.Series[0].Points.AddXY(2, Convert.ToInt32(data1[0].ToString()));
                this.LabelNumber.Text = data1[0].ToString();
                data1.Close();
                //String[] Class = new String[] { "食物", "毛巾", "牙具", "澡具", "洗发水", "沐浴乳", "衣物", "煤炭", "茶水" };
                //int[] ItemNumbers = new int[] { 3000, 4000, 2000, 3000, 1500, 1500, 4000, 5000, 2000 };

                //SqlCommand ItemNumbersCmd = new SqlCommand("select * from ViewItemNumbers", GlobalClass.Connection);
                QueryCmd.CommandText = "select * from ViewItemNumbers";
                SqlDataReader data2 = QueryCmd.ExecuteReader();
                ArrayList ItemName = new ArrayList();
                ArrayList ItemNumbers = new ArrayList();
                int i = 0;
                while (data2.Read())
                {
                    ItemName.Add(data2[0].ToString());
                    ItemNumbers.Add(Convert.ToInt32(data2[1].ToString()));
                    i++;
                }
                for (int j = 0; j < ItemName.Count; j++)
                {
                    //ItemNumbers.Add(data2[j]);
                    ChartStore.Series[0].Points.AddXY(ItemName[j], ItemNumbers[j]);
                }
                data2.Close();

                QueryCmd.CommandText = "select * from ViewRevenues";
                SqlDataReader data3 = QueryCmd.ExecuteReader();
                ArrayList RevenuesPrice = new ArrayList();
                //ArrayList RevenuesDate = new ArrayList();
                //int k = 0;
                while (data3.Read())
                {
                    RevenuesPrice.Add(Convert.ToInt32(data3[0].ToString()));
                    //RevenuesDate.Add(Convert.ToDateTime(data3[1].ToString()));
                    //k++;
                }
                for (int j = 0; j < 12; j++)
                {
                    ChartTurnOver.Series[0].Points.AddXY(j + 1, RevenuesPrice[j]);
                    ChartTurnOver.Series[0].LegendText = "月营业额";
                }
                data3.Close();

                QueryCmd.CommandText = "select * from ViewExpenditure";
                SqlDataReader data4= QueryCmd.ExecuteReader();
                //ArrayList AllExpenditure = new ArrayList(13);
                int[] AllExpenditure = new int[12] { 0,0,0,0,0,0,0,0,0,0,0,0};
                ArrayList ExpenditurePrice = new ArrayList();
                ArrayList ExpenditureName = new ArrayList();
                //ArrayList SalarysExpenditure = new ArrayList();

                ArrayList ExpenditurePowers = new ArrayList();
                ArrayList ExpenditureItems = new ArrayList();
                ArrayList ExpenditureSalarys = new ArrayList();

                while (data4.Read())
                {
                    ExpenditurePrice.Add(Convert.ToInt32(data4[0].ToString()));
                    ExpenditureName.Add(data4[1].ToString());
                }
                for (int j = 0; j < ExpenditurePrice.Count; j++)
                {
                    if (ExpenditureName[j].ToString() == "水电")
                    {

                        ExpenditurePowers.Add(ExpenditurePrice[j]);
                        //MessageBox.Show("水电:" + ExpenditurePrice[j]);
                    }
                    if (ExpenditureName[j].ToString() == "物资")
                    {
                        ExpenditureItems.Add(ExpenditurePrice[j]);
                        //MessageBox.Show("物资:" + ExpenditurePrice[j]);
                    }

                    if (ExpenditureName[j].ToString() == "工资")
                    {
                        ExpenditureSalarys.Add(ExpenditurePrice[j]);
                        //MessageBox.Show("工资:" + ExpenditurePrice[j]);
                    }
                        
                }
                for (int j = 0; j < 12; j++)
                {
                    ChartExpenditure.Series[0].Points.AddXY(j + 1, ExpenditurePowers[j]);
                    ChartExpenditure.Series[0].LegendText = "水电支出";
                    ChartExpenditure.Series[1].Points.AddXY(j + 1, ExpenditureItems[j]);
                    ChartExpenditure.Series[1].LegendText = "物资支出";
                    ChartExpenditure.Series[2].Points.AddXY(j + 1, ExpenditureSalarys[j]);
                    ChartExpenditure.Series[2].LegendText = "工资支出";
                    AllExpenditure[j] = Convert.ToInt32(ExpenditurePowers[j]) + Convert.ToInt32(ExpenditureItems[j]) + Convert.ToInt32(ExpenditureSalarys[j]);
                    //MessageBox.Show("ALL:" + AllExpenditure[j]);
                }
                data4.Close();
                /*PowerExpenditure.Add(Convert.ToInt32(data4[0].ToString()));
                ItemsExpenditure.Add(Convert.ToInt32(data4[1].ToString()));
                SalarysExpenditure.Add(Convert.ToInt32(data4[2].ToString()));*/
                


                //int[] GrossProfit = new int[] { 45, 42, 40, 35, 30, 34, 32, 38, 40, 43, 45, 44 };
                for (int j = 0; j < 12; j++)
                {
                    ChartIncome.Series[0].Points.AddXY(j + 1, RevenuesPrice[j]);
                    ChartIncome.Series[0].LegendText = "毛  利  润";
                    ChartIncome.Series[1].Points.AddXY(j + 1, Convert.ToInt32(RevenuesPrice[j])-AllExpenditure[j]);
                    ChartIncome.Series[1].LegendText = "净  利  润";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalClass.Connection.Close();
            }
            
            

            /*int[] TurnOverNumbers = new int[] { 45, 42, 40, 35, 30, 34, 32, 38, 40, 43, 45, 44 };
            for (int i = 0; i < 12; i++)
            {
                ChartTurnOver.Series[0].Points.AddXY(i + 1, TurnOverNumbers[i]);
                ChartTurnOver.Series[0].LegendText = "月营业额";
            }*/

            /*int[] GrossProfit = new int[] { 45, 42, 40, 35, 30, 34, 32, 38, 40, 43, 45, 44 };
            for (int i = 0; i < 12; i++)
            {
                ChartIncome.Series[0].Points.AddXY(i + 1, GrossProfit[i]);
                ChartIncome.Series[0].LegendText = "毛  利  润";
                ChartIncome.Series[1].Points.AddXY(i + 1, 30);
                ChartIncome.Series[1].LegendText = "净  利  润";
            }*/

            /*float[] HydropowerExpenditure = new float[] { 20f, 15f, 14f, 12f, 12f, 13f, 18f, 16f, 17f, 19f, 21f, 21f };
            float[] ItemExpenditure = new float[] { 30f, 20f, 21f, 19f, 20f, 23f, 25f, 24f, 26f, 28f, 31f, 31f };
            float[] SalaryExpenditure = new float[] { 15f, 15f, 15f, 15f, 15f, 15f, 15f, 15f, 15f, 15f, 15f, 15f };
            for (int i = 0; i < 12; i++)
            {
                ChartExpenditure.Series[0].Points.AddXY(i + 1, HydropowerExpenditure[i]);
                ChartExpenditure.Series[0].LegendText = "水电支出";
                ChartExpenditure.Series[1].Points.AddXY(i + 1, ItemExpenditure[i]);
                ChartExpenditure.Series[1].LegendText = "物资支出";
                ChartExpenditure.Series[2].Points.AddXY(i + 1, 12);
                ChartExpenditure.Series[2].LegendText = "工资支出";
            }*/
        }
    }
}