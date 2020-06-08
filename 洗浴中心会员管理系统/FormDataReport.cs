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
    public partial class FormDataReport : Form
    {
        public FormDataReport()
        {
            InitializeComponent();
        }

        private void FormDataReport_Load(object sender, EventArgs e)
        {
            ChartConsumerNumbers.Series[0].Points.AddXY(1, 300);
            ChartConsumerNumbers.Series[0].Points.AddXY(2, 200);

            String[] Class = new String[] { "食物", "毛巾", "牙具", "澡具", "洗发水", "沐浴乳", "衣物", "煤炭", "茶水" };
            int[] ItemNumbers = new int[] { 3000, 4000, 2000, 3000, 1500, 1500, 4000, 5000, 2000 };
            for (int i = 0; i < 9; i++)
            {
                ChartStore.Series[0].Points.AddXY(Class[i], ItemNumbers[i]);
            }

            int[] TurnOverNumbers = new int[] { 45, 42, 40, 35, 30, 34, 32, 38, 40, 43, 45, 44 };
            for (int i = 0; i < 12; i++)
            {
                ChartTurnOver.Series[0].Points.AddXY(i + 1, TurnOverNumbers[i]);
                ChartTurnOver.Series[0].LegendText = "月营业额";
            }

            int[] GrossProfit = new int[] { 45, 42, 40, 35, 30, 34, 32, 38, 40, 43, 45, 44 };
            for (int i = 0; i < 12; i++)
            {
                ChartIncome.Series[0].Points.AddXY(i + 1, GrossProfit[i]);
                ChartIncome.Series[0].LegendText = "毛  利  润";
                ChartIncome.Series[1].Points.AddXY(i + 1, 30);
                ChartIncome.Series[1].LegendText = "净  利  润";
            }

            float[] HydropowerExpenditure = new float[] { 20f, 15f, 14f, 12f, 12f, 13f, 18f, 16f, 17f, 19f, 21f, 21f };
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
            }
        }
    }
}