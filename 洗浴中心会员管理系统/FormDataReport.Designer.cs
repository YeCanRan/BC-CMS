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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.ChartConsumerNumbers.ChartAreas.Add(chartArea11);
            this.ChartConsumerNumbers.Location = new System.Drawing.Point(73, 21);
            this.ChartConsumerNumbers.Name = "ChartConsumerNumbers";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series17.CustomProperties = "DoughnutRadius=30";
            series17.Name = "Series1";
            this.ChartConsumerNumbers.Series.Add(series17);
            this.ChartConsumerNumbers.Size = new System.Drawing.Size(160, 160);
            this.ChartConsumerNumbers.TabIndex = 0;
            this.ChartConsumerNumbers.Text = "chart1";
            title5.Font = new System.Drawing.Font("微软雅黑", 8F);
            title5.Name = "Title1";
            title5.Text = "当前客人数量";
            this.ChartConsumerNumbers.Titles.Add(title5);
            // 
            // ChartTurnOver
            // 
            this.ChartTurnOver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartTurnOver.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.ChartTurnOver.ChartAreas.Add(chartArea12);
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            legend7.TitleBackColor = System.Drawing.Color.Transparent;
            this.ChartTurnOver.Legends.Add(legend7);
            this.ChartTurnOver.Location = new System.Drawing.Point(15, 10);
            this.ChartTurnOver.Name = "ChartTurnOver";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.ChartTurnOver.Series.Add(series18);
            this.ChartTurnOver.Size = new System.Drawing.Size(983, 140);
            this.ChartTurnOver.TabIndex = 0;
            this.ChartTurnOver.Text = "chart1";
            // 
            // ChartStore
            // 
            this.ChartStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartStore.BackColor = System.Drawing.Color.Transparent;
            chartArea13.BackColor = System.Drawing.Color.Transparent;
            chartArea13.Name = "ChartArea1";
            this.ChartStore.ChartAreas.Add(chartArea13);
            this.ChartStore.Location = new System.Drawing.Point(236, 21);
            this.ChartStore.Name = "ChartStore";
            series19.ChartArea = "ChartArea1";
            series19.Name = "Series1";
            this.ChartStore.Series.Add(series19);
            this.ChartStore.Size = new System.Drawing.Size(753, 160);
            this.ChartStore.TabIndex = 0;
            this.ChartStore.Text = "chart1";
            title6.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            title6.Text = "物资储量";
            this.ChartStore.Titles.Add(title6);
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
            chartArea14.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.ChartExpenditure.ChartAreas.Add(chartArea14);
            legend8.BackColor = System.Drawing.Color.Transparent;
            legend8.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.ChartExpenditure.Legends.Add(legend8);
            this.ChartExpenditure.Location = new System.Drawing.Point(15, 330);
            this.ChartExpenditure.Name = "ChartExpenditure";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Series2";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Series3";
            this.ChartExpenditure.Series.Add(series20);
            this.ChartExpenditure.Series.Add(series21);
            this.ChartExpenditure.Series.Add(series22);
            this.ChartExpenditure.Size = new System.Drawing.Size(983, 140);
            this.ChartExpenditure.TabIndex = 0;
            this.ChartExpenditure.Text = "chart1";
            // 
            // ChartIncome
            // 
            this.ChartIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartIncome.BackColor = System.Drawing.Color.Transparent;
            chartArea15.BackColor = System.Drawing.Color.Transparent;
            chartArea15.Name = "ChartArea1";
            this.ChartIncome.ChartAreas.Add(chartArea15);
            legend9.BackColor = System.Drawing.Color.Transparent;
            legend9.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend9.IsTextAutoFit = false;
            legend9.Name = "Legend1";
            this.ChartIncome.Legends.Add(legend9);
            this.ChartIncome.Location = new System.Drawing.Point(15, 170);
            this.ChartIncome.Name = "ChartIncome";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Series1";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "Series2";
            this.ChartIncome.Series.Add(series23);
            this.ChartIncome.Series.Add(series24);
            this.ChartIncome.Size = new System.Drawing.Size(983, 140);
            this.ChartIncome.TabIndex = 0;
            this.ChartIncome.Text = "chart1";
            // 
            // FormDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
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