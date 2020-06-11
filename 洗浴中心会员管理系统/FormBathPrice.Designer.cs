namespace 洗浴中心会员管理系统
{
    partial class FormBathPrice
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
            this.PanelHead = new System.Windows.Forms.Panel();
            this.LabelPresentPrice = new System.Windows.Forms.Label();
            this.LabelOriginalPrice = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.PanelPriceList = new System.Windows.Forms.Panel();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelHead.Controls.Add(this.LabelPresentPrice);
            this.PanelHead.Controls.Add(this.LabelOriginalPrice);
            this.PanelHead.Controls.Add(this.LabelName);
            this.PanelHead.Controls.Add(this.LabelID);
            this.PanelHead.Controls.Add(this.ButtonClear);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1014, 100);
            this.PanelHead.TabIndex = 7;
            // 
            // LabelPresentPrice
            // 
            this.LabelPresentPrice.AutoSize = true;
            this.LabelPresentPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPresentPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelPresentPrice.Location = new System.Drawing.Point(521, 39);
            this.LabelPresentPrice.Name = "LabelPresentPrice";
            this.LabelPresentPrice.Size = new System.Drawing.Size(37, 20);
            this.LabelPresentPrice.TabIndex = 15;
            this.LabelPresentPrice.Text = "现价";
            // 
            // LabelOriginalPrice
            // 
            this.LabelOriginalPrice.AutoSize = true;
            this.LabelOriginalPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOriginalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelOriginalPrice.Location = new System.Drawing.Point(364, 39);
            this.LabelOriginalPrice.Name = "LabelOriginalPrice";
            this.LabelOriginalPrice.Size = new System.Drawing.Size(37, 20);
            this.LabelOriginalPrice.TabIndex = 16;
            this.LabelOriginalPrice.Text = "原价";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.Location = new System.Drawing.Point(179, 39);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(65, 20);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "消费名称";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(28, 39);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(24, 20);
            this.LabelID.TabIndex = 18;
            this.LabelID.Text = "ID";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonClear.Location = new System.Drawing.Point(893, 34);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(80, 30);
            this.ButtonClear.TabIndex = 1;
            this.ButtonClear.Text = "清 空";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // PanelPriceList
            // 
            this.PanelPriceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPriceList.Location = new System.Drawing.Point(0, 100);
            this.PanelPriceList.Name = "PanelPriceList";
            this.PanelPriceList.Size = new System.Drawing.Size(1014, 581);
            this.PanelPriceList.TabIndex = 9;
            // 
            // FormBathPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelPriceList);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBathPrice";
            this.Text = "FormBathPrice";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelPriceList;
        private System.Windows.Forms.Label LabelPresentPrice;
        private System.Windows.Forms.Label LabelOriginalPrice;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button ButtonClear;
    }
}