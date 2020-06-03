namespace 洗浴中心会员管理系统
{
    partial class UserControlRechargePriceList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelGiftPriceTips = new System.Windows.Forms.Label();
            this.LabelRechargePriceTips = new System.Windows.Forms.Label();
            this.LabelCardNo = new System.Windows.Forms.Label();
            this.ButtonChoose = new System.Windows.Forms.Button();
            this.LabelGiftPrice = new System.Windows.Forms.Label();
            this.LabelRechargePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelGiftPriceTips
            // 
            this.LabelGiftPriceTips.AutoSize = true;
            this.LabelGiftPriceTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelGiftPriceTips.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGiftPriceTips.Location = new System.Drawing.Point(302, 21);
            this.LabelGiftPriceTips.Name = "LabelGiftPriceTips";
            this.LabelGiftPriceTips.Size = new System.Drawing.Size(63, 17);
            this.LabelGiftPriceTips.TabIndex = 5;
            this.LabelGiftPriceTips.Text = "赠送金额 :";
            // 
            // LabelRechargePriceTips
            // 
            this.LabelRechargePriceTips.AutoSize = true;
            this.LabelRechargePriceTips.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelRechargePriceTips.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelRechargePriceTips.Location = new System.Drawing.Point(127, 21);
            this.LabelRechargePriceTips.Name = "LabelRechargePriceTips";
            this.LabelRechargePriceTips.Size = new System.Drawing.Size(63, 17);
            this.LabelRechargePriceTips.TabIndex = 7;
            this.LabelRechargePriceTips.Text = "充值金额 :";
            // 
            // LabelCardNo
            // 
            this.LabelCardNo.AutoSize = true;
            this.LabelCardNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCardNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCardNo.Location = new System.Drawing.Point(28, 21);
            this.LabelCardNo.Name = "LabelCardNo";
            this.LabelCardNo.Size = new System.Drawing.Size(56, 17);
            this.LabelCardNo.TabIndex = 8;
            this.LabelCardNo.Text = "会员卡号";
            // 
            // ButtonChoose
            // 
            this.ButtonChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonChoose.FlatAppearance.BorderSize = 0;
            this.ButtonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChoose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonChoose.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonChoose.Location = new System.Drawing.Point(893, 14);
            this.ButtonChoose.Name = "ButtonChoose";
            this.ButtonChoose.Size = new System.Drawing.Size(80, 30);
            this.ButtonChoose.TabIndex = 2;
            this.ButtonChoose.Text = "选 择";
            this.ButtonChoose.UseVisualStyleBackColor = false;
            // 
            // LabelGiftPrice
            // 
            this.LabelGiftPrice.AutoSize = true;
            this.LabelGiftPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelGiftPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelGiftPrice.Location = new System.Drawing.Point(371, 21);
            this.LabelGiftPrice.Name = "LabelGiftPrice";
            this.LabelGiftPrice.Size = new System.Drawing.Size(58, 17);
            this.LabelGiftPrice.TabIndex = 3;
            this.LabelGiftPrice.Text = "000.00元";
            // 
            // LabelRechargePrice
            // 
            this.LabelRechargePrice.AutoSize = true;
            this.LabelRechargePrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelRechargePrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelRechargePrice.Location = new System.Drawing.Point(196, 21);
            this.LabelRechargePrice.Name = "LabelRechargePrice";
            this.LabelRechargePrice.Size = new System.Drawing.Size(58, 17);
            this.LabelRechargePrice.TabIndex = 4;
            this.LabelRechargePrice.Text = "000.00元";
            // 
            // UserControlRechargePriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.LabelGiftPrice);
            this.Controls.Add(this.LabelRechargePrice);
            this.Controls.Add(this.LabelGiftPriceTips);
            this.Controls.Add(this.LabelRechargePriceTips);
            this.Controls.Add(this.LabelCardNo);
            this.Controls.Add(this.ButtonChoose);
            this.Name = "UserControlRechargePriceList";
            this.Size = new System.Drawing.Size(1014, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelGiftPriceTips;
        private System.Windows.Forms.Label LabelRechargePriceTips;
        private System.Windows.Forms.Label LabelCardNo;
        private System.Windows.Forms.Button ButtonChoose;
        private System.Windows.Forms.Label LabelGiftPrice;
        private System.Windows.Forms.Label LabelRechargePrice;
    }
}
