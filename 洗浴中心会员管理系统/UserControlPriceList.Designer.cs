namespace 洗浴中心会员管理系统
{
    partial class UserControlPriceList
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TextBoxOriginalPrice = new System.Windows.Forms.TextBox();
            this.LabelYUAN1 = new System.Windows.Forms.Label();
            this.LabelYUAN2 = new System.Windows.Forms.Label();
            this.TextBoxPresentPrice = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.Location = new System.Drawing.Point(180, 21);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(56, 17);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "消费名称";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(31, 21);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(21, 17);
            this.LabelID.TabIndex = 8;
            this.LabelID.Text = "ID";
            // 
            // TextBoxOriginalPrice
            // 
            this.TextBoxOriginalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxOriginalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxOriginalPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxOriginalPrice.Location = new System.Drawing.Point(368, 20);
            this.TextBoxOriginalPrice.Name = "TextBoxOriginalPrice";
            this.TextBoxOriginalPrice.ReadOnly = true;
            this.TextBoxOriginalPrice.Size = new System.Drawing.Size(66, 19);
            this.TextBoxOriginalPrice.TabIndex = 1;
            // 
            // LabelYUAN1
            // 
            this.LabelYUAN1.AutoSize = true;
            this.LabelYUAN1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelYUAN1.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelYUAN1.Location = new System.Drawing.Point(440, 21);
            this.LabelYUAN1.Name = "LabelYUAN1";
            this.LabelYUAN1.Size = new System.Drawing.Size(20, 17);
            this.LabelYUAN1.TabIndex = 6;
            this.LabelYUAN1.Text = "元";
            // 
            // LabelYUAN2
            // 
            this.LabelYUAN2.AutoSize = true;
            this.LabelYUAN2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelYUAN2.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelYUAN2.Location = new System.Drawing.Point(597, 21);
            this.LabelYUAN2.Name = "LabelYUAN2";
            this.LabelYUAN2.Size = new System.Drawing.Size(20, 17);
            this.LabelYUAN2.TabIndex = 6;
            this.LabelYUAN2.Text = "元";
            // 
            // TextBoxPresentPrice
            // 
            this.TextBoxPresentPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxPresentPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPresentPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPresentPrice.Location = new System.Drawing.Point(525, 20);
            this.TextBoxPresentPrice.Name = "TextBoxPresentPrice";
            this.TextBoxPresentPrice.Size = new System.Drawing.Size(66, 19);
            this.TextBoxPresentPrice.TabIndex = 2;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonOK.Location = new System.Drawing.Point(893, 14);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(80, 30);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "确 定";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // UserControlPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxPresentPrice);
            this.Controls.Add(this.TextBoxOriginalPrice);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelYUAN2);
            this.Controls.Add(this.LabelYUAN1);
            this.Controls.Add(this.LabelID);
            this.Name = "UserControlPriceList";
            this.Size = new System.Drawing.Size(1014, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TextBoxOriginalPrice;
        private System.Windows.Forms.Label LabelYUAN1;
        private System.Windows.Forms.Label LabelYUAN2;
        private System.Windows.Forms.TextBox TextBoxPresentPrice;
        private System.Windows.Forms.Button ButtonOK;
    }
}
