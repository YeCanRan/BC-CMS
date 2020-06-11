namespace 洗浴中心会员管理系统
{
    partial class FormCouponIssue
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
            this.LabelEmpNo = new System.Windows.Forms.Label();
            this.LabelNumbers = new System.Windows.Forms.Label();
            this.LabelEquivalent = new System.Windows.Forms.Label();
            this.LabelDiscount = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonAddLeaflet = new System.Windows.Forms.Button();
            this.ButtonAddBathCoupon = new System.Windows.Forms.Button();
            this.ButtonAddDiscountCoupon = new System.Windows.Forms.Button();
            this.ButtonAddCashCoupon = new System.Windows.Forms.Button();
            this.PanelCouponList = new System.Windows.Forms.Panel();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelHead.Controls.Add(this.LabelEmpNo);
            this.PanelHead.Controls.Add(this.LabelNumbers);
            this.PanelHead.Controls.Add(this.LabelEquivalent);
            this.PanelHead.Controls.Add(this.LabelDiscount);
            this.PanelHead.Controls.Add(this.LabelClass);
            this.PanelHead.Controls.Add(this.LabelID);
            this.PanelHead.Controls.Add(this.ButtonAddLeaflet);
            this.PanelHead.Controls.Add(this.ButtonAddBathCoupon);
            this.PanelHead.Controls.Add(this.ButtonAddDiscountCoupon);
            this.PanelHead.Controls.Add(this.ButtonAddCashCoupon);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1014, 100);
            this.PanelHead.TabIndex = 8;
            // 
            // LabelEmpNo
            // 
            this.LabelEmpNo.AutoSize = true;
            this.LabelEmpNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelEmpNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelEmpNo.Location = new System.Drawing.Point(452, 42);
            this.LabelEmpNo.Name = "LabelEmpNo";
            this.LabelEmpNo.Size = new System.Drawing.Size(93, 20);
            this.LabelEmpNo.TabIndex = 6;
            this.LabelEmpNo.Text = "发放员工编号";
            // 
            // LabelNumbers
            // 
            this.LabelNumbers.AutoSize = true;
            this.LabelNumbers.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelNumbers.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNumbers.Location = new System.Drawing.Point(373, 42);
            this.LabelNumbers.Name = "LabelNumbers";
            this.LabelNumbers.Size = new System.Drawing.Size(37, 20);
            this.LabelNumbers.TabIndex = 6;
            this.LabelNumbers.Text = "数量";
            // 
            // LabelEquivalent
            // 
            this.LabelEquivalent.AutoSize = true;
            this.LabelEquivalent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelEquivalent.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelEquivalent.Location = new System.Drawing.Point(280, 42);
            this.LabelEquivalent.Name = "LabelEquivalent";
            this.LabelEquivalent.Size = new System.Drawing.Size(51, 20);
            this.LabelEquivalent.TabIndex = 6;
            this.LabelEquivalent.Text = "代金额";
            // 
            // LabelDiscount
            // 
            this.LabelDiscount.AutoSize = true;
            this.LabelDiscount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDiscount.Location = new System.Drawing.Point(173, 42);
            this.LabelDiscount.Name = "LabelDiscount";
            this.LabelDiscount.Size = new System.Drawing.Size(65, 20);
            this.LabelDiscount.TabIndex = 6;
            this.LabelDiscount.Text = "折扣幅度";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelClass.Location = new System.Drawing.Point(94, 42);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(37, 20);
            this.LabelClass.TabIndex = 6;
            this.LabelClass.Text = "类别";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(28, 42);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(24, 20);
            this.LabelID.TabIndex = 6;
            this.LabelID.Text = "ID";
            // 
            // ButtonAddLeaflet
            // 
            this.ButtonAddLeaflet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddLeaflet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonAddLeaflet.FlatAppearance.BorderSize = 0;
            this.ButtonAddLeaflet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddLeaflet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAddLeaflet.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAddLeaflet.Location = new System.Drawing.Point(593, 37);
            this.ButtonAddLeaflet.Name = "ButtonAddLeaflet";
            this.ButtonAddLeaflet.Size = new System.Drawing.Size(80, 30);
            this.ButtonAddLeaflet.TabIndex = 1;
            this.ButtonAddLeaflet.Text = "添加宣传单";
            this.ButtonAddLeaflet.UseVisualStyleBackColor = false;
            this.ButtonAddLeaflet.Click += new System.EventHandler(this.ButtonAddLeaflet_Click);
            // 
            // ButtonAddBathCoupon
            // 
            this.ButtonAddBathCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddBathCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonAddBathCoupon.FlatAppearance.BorderSize = 0;
            this.ButtonAddBathCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddBathCoupon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAddBathCoupon.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAddBathCoupon.Location = new System.Drawing.Point(693, 37);
            this.ButtonAddBathCoupon.Name = "ButtonAddBathCoupon";
            this.ButtonAddBathCoupon.Size = new System.Drawing.Size(80, 30);
            this.ButtonAddBathCoupon.TabIndex = 2;
            this.ButtonAddBathCoupon.Text = "添加浴资券";
            this.ButtonAddBathCoupon.UseVisualStyleBackColor = false;
            this.ButtonAddBathCoupon.Click += new System.EventHandler(this.ButtonAddBathCoupon_Click);
            // 
            // ButtonAddDiscountCoupon
            // 
            this.ButtonAddDiscountCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddDiscountCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonAddDiscountCoupon.FlatAppearance.BorderSize = 0;
            this.ButtonAddDiscountCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDiscountCoupon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAddDiscountCoupon.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAddDiscountCoupon.Location = new System.Drawing.Point(793, 37);
            this.ButtonAddDiscountCoupon.Name = "ButtonAddDiscountCoupon";
            this.ButtonAddDiscountCoupon.Size = new System.Drawing.Size(80, 30);
            this.ButtonAddDiscountCoupon.TabIndex = 3;
            this.ButtonAddDiscountCoupon.Text = "添加打折券";
            this.ButtonAddDiscountCoupon.UseVisualStyleBackColor = false;
            this.ButtonAddDiscountCoupon.Click += new System.EventHandler(this.ButtonAddDiscountCoupon_Click);
            // 
            // ButtonAddCashCoupon
            // 
            this.ButtonAddCashCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddCashCoupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonAddCashCoupon.FlatAppearance.BorderSize = 0;
            this.ButtonAddCashCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCashCoupon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAddCashCoupon.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAddCashCoupon.Location = new System.Drawing.Point(893, 37);
            this.ButtonAddCashCoupon.Name = "ButtonAddCashCoupon";
            this.ButtonAddCashCoupon.Size = new System.Drawing.Size(80, 30);
            this.ButtonAddCashCoupon.TabIndex = 4;
            this.ButtonAddCashCoupon.Text = "添加代金券";
            this.ButtonAddCashCoupon.UseVisualStyleBackColor = false;
            this.ButtonAddCashCoupon.Click += new System.EventHandler(this.ButtonAddCashCoupon_Click);
            // 
            // PanelCouponList
            // 
            this.PanelCouponList.AutoScroll = true;
            this.PanelCouponList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCouponList.Location = new System.Drawing.Point(0, 100);
            this.PanelCouponList.Name = "PanelCouponList";
            this.PanelCouponList.Size = new System.Drawing.Size(1014, 581);
            this.PanelCouponList.TabIndex = 9;
            // 
            // FormCouponIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelCouponList);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCouponIssue";
            this.Text = "FormCouponIssue";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonAddCashCoupon;
        private System.Windows.Forms.Panel PanelCouponList;
        private System.Windows.Forms.Button ButtonAddLeaflet;
        private System.Windows.Forms.Button ButtonAddBathCoupon;
        private System.Windows.Forms.Button ButtonAddDiscountCoupon;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelEmpNo;
        private System.Windows.Forms.Label LabelNumbers;
        private System.Windows.Forms.Label LabelEquivalent;
        private System.Windows.Forms.Label LabelDiscount;
        private System.Windows.Forms.Label LabelClass;
    }
}