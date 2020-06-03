namespace 洗浴中心会员管理系统
{
    partial class UserControlSalaryRiseList
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
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelClass = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.LabelYUAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(32, 20);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(21, 17);
            this.LabelID.TabIndex = 8;
            this.LabelID.Text = "ID";
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
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "确 定";
            this.ButtonOK.UseVisualStyleBackColor = false;
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelClass.Location = new System.Drawing.Point(144, 20);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(32, 17);
            this.LabelClass.TabIndex = 7;
            this.LabelClass.Text = "类别";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPrice.Location = new System.Drawing.Point(271, 17);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(129, 22);
            this.TextBoxPrice.TabIndex = 9;
            // 
            // LabelYUAN
            // 
            this.LabelYUAN.AutoSize = true;
            this.LabelYUAN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelYUAN.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelYUAN.Location = new System.Drawing.Point(406, 20);
            this.LabelYUAN.Name = "LabelYUAN";
            this.LabelYUAN.Size = new System.Drawing.Size(20, 17);
            this.LabelYUAN.TabIndex = 5;
            this.LabelYUAN.Text = "元";
            // 
            // UserControlSalaryRiseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.LabelYUAN);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.ButtonOK);
            this.Name = "UserControlSalaryRiseList";
            this.Size = new System.Drawing.Size(1014, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label LabelYUAN;
    }
}
