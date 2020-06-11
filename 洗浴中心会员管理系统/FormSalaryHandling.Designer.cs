namespace 洗浴中心会员管理系统
{
    partial class FormSalaryHandling
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
            this.LabelSalaryRise = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.PanelSalaryRiseList = new System.Windows.Forms.Panel();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelHead.Controls.Add(this.LabelSalaryRise);
            this.PanelHead.Controls.Add(this.LabelClass);
            this.PanelHead.Controls.Add(this.LabelID);
            this.PanelHead.Controls.Add(this.ButtonClear);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1014, 100);
            this.PanelHead.TabIndex = 7;
            // 
            // LabelSalaryRise
            // 
            this.LabelSalaryRise.AutoSize = true;
            this.LabelSalaryRise.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSalaryRise.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSalaryRise.Location = new System.Drawing.Point(267, 41);
            this.LabelSalaryRise.Name = "LabelSalaryRise";
            this.LabelSalaryRise.Size = new System.Drawing.Size(65, 20);
            this.LabelSalaryRise.TabIndex = 7;
            this.LabelSalaryRise.Text = "涨薪幅度";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelClass.Location = new System.Drawing.Point(141, 41);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(37, 20);
            this.LabelClass.TabIndex = 8;
            this.LabelClass.Text = "类别";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(28, 41);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(24, 20);
            this.LabelID.TabIndex = 9;
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
            this.ButtonClear.Location = new System.Drawing.Point(893, 36);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(80, 30);
            this.ButtonClear.TabIndex = 1;
            this.ButtonClear.Text = "清 空";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // PanelSalaryRiseList
            // 
            this.PanelSalaryRiseList.AutoScroll = true;
            this.PanelSalaryRiseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSalaryRiseList.Location = new System.Drawing.Point(0, 100);
            this.PanelSalaryRiseList.Name = "PanelSalaryRiseList";
            this.PanelSalaryRiseList.Size = new System.Drawing.Size(1014, 581);
            this.PanelSalaryRiseList.TabIndex = 8;
            // 
            // FormSalaryHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelSalaryRiseList);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalaryHandling";
            this.Text = "FormSalaryHandling";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelSalaryRiseList;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label LabelSalaryRise;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label LabelID;
    }
}