namespace 洗浴中心会员管理系统
{
    partial class FormDataReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartConsumerNumbers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTurnOver = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartStore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.LabelREN = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ChartExpenditure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartConsumerNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTurnOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStore)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExpenditure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartConsumerNumbers
            // 
            this.ChartConsumerNumbers.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartConsumerNumbers.ChartAreas.Add(chartArea1);
            this.ChartConsumerNumbers.Location = new System.Drawing.Point(73, 21);
            this.ChartConsumerNumbers.Name = "ChartConsumerNumbers";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "DoughnutRadius=30";
            series1.Name = "Series1";
            this.ChartConsumerNumbers.Series.Add(series1);
            this.ChartConsumerNumbers.Size = new System.Drawing.Size(160, 160);
            this.ChartConsumerNumbers.TabIndex = 0;
            this.ChartConsumerNumbers.Text = "chart1";
            title1.Font = new System.Drawing.Font("微软雅黑", 8F);
            title1.Name = "Title1";
            title1.Text = "当前客人数量";
            this.ChartConsumerNumbers.Titles.Add(title1);
            // 
            // ChartTurnOver
            // 
            this.ChartTurnOver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartTurnOver.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChartTurnOver.ChartAreas.Add(chartArea2);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.ChartTurnOver.Legends.Add(legend1);
            this.ChartTurnOver.Location = new System.Drawing.Point(15, 10);
            this.ChartTurnOver.Name = "ChartTurnOver";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartTurnOver.Series.Add(series2);
            this.ChartTurnOver.Size = new System.Drawing.Size(983, 140);
            this.ChartTurnOver.TabIndex = 0;
            this.ChartTurnOver.Text = "chart1";
            // 
            // ChartStore
            // 
            this.ChartStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartStore.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ChartStore.ChartAreas.Add(chartArea3);
            this.ChartStore.Location = new System.Drawing.Point(236, 21);
            this.ChartStore.Name = "ChartStore";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.ChartStore.Series.Add(series3);
            this.ChartStore.Size = new System.Drawing.Size(753, 160);
            this.ChartStore.TabIndex = 0;
            this.ChartStore.Text = "chart1";
            title2.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "物资储量";
            this.ChartStore.Titles.Add(title2);
            // 
            // PanelHead
            // 
            this.PanelHead.Controls.Add(this.LabelREN);
            this.PanelHead.Controls.Add(this.LabelNumber);
            this.PanelHead.Controls.Add(this.ChartConsumerNumbers);
            this.PanelHead.Controls.Add(this.ChartStore);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1014, 201);
            this.PanelHead.TabIndex = 1;
            // 
            // LabelREN
            // 
            this.LabelREN.AutoSize = true;
            this.LabelREN.BackColor = System.Drawing.Color.Transparent;
            this.LabelREN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelREN.Location = new System.Drawing.Point(166, 109);
            this.LabelREN.Name = "LabelREN";
            this.LabelREN.Size = new System.Drawing.Size(20, 17);
            this.LabelREN.TabIndex = 1;
            this.LabelREN.Text = "人";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumber.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelNumber.Location = new System.Drawing.Point(124, 96);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(48, 28);
            this.LabelNumber.TabIndex = 1;
            this.LabelNumber.Text = "000";
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.ChartExpenditure);
            this.PanelBottom.Controls.Add(this.ChartIncome);
            this.PanelBottom.Controls.Add(this.ChartTurnOver);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBottom.Location = new System.Drawing.Point(0, 201);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1014, 480);
            this.PanelBottom.TabIndex = 2;
            // 
            // ChartExpenditure
            // 
            this.ChartExpenditure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartExpenditure.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.ChartExpenditure.ChartAreas.Add(chartArea4);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.ChartExpenditure.Legends.Add(legend2);
            this.ChartExpenditure.Location = new System.Drawing.Point(15, 330);
            this.ChartExpenditure.Name = "ChartExpenditure";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series3";
            this.ChartExpenditure.Series.Add(series4);
            this.ChartExpenditure.Series.Add(series5);
            this.ChartExpenditure.Series.Add(series6);
            this.ChartExpenditure.Size = new System.Drawing.Size(983, 140);
            this.ChartExpenditure.TabIndex = 0;
            this.ChartExpenditure.Text = "chart1";
            // 
            // ChartIncome
            // 
            this.ChartIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartIncome.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.ChartIncome.ChartAreas.Add(chartArea5);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.ChartIncome.Legends.Add(legend3);
            this.ChartIncome.Location = new System.Drawing.Point(15, 170);
            this.ChartIncome.Name = "ChartIncome";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.ChartIncome.Series.Add(series7);
            this.ChartIncome.Series.Add(series8);
            this.ChartIncome.Size = new System.Drawing.Size(983, 140);
            this.ChartIncome.TabIndex = 0;
            this.ChartIncome.Text = "chart1";
            // 
            // FormDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDataReport";
            this.Text = "FormDataReport";
            this.Load += new System.EventHandler(this.FormDataReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartConsumerNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTurnOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStore)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartExpenditure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartConsumerNumbers;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTurnOver;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartStore;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartExpenditure;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartIncome;
        private System.Windows.Forms.Label LabelREN;
        private System.Windows.Forms.Label LabelNumber;
    }
}