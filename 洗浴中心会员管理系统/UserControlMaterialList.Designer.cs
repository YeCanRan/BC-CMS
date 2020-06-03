namespace 洗浴中心会员管理系统
{
    partial class UserControlMaterialList
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
            this.TextBoxIncrement = new System.Windows.Forms.TextBox();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelTotalReserves = new System.Windows.Forms.Label();
            this.LabelCurrentReserve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxIncrement
            // 
            this.TextBoxIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxIncrement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxIncrement.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxIncrement.Location = new System.Drawing.Point(608, 18);
            this.TextBoxIncrement.Name = "TextBoxIncrement";
            this.TextBoxIncrement.Size = new System.Drawing.Size(129, 22);
            this.TextBoxIncrement.TabIndex = 16;
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelClass.Location = new System.Drawing.Point(82, 21);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(32, 17);
            this.LabelClass.TabIndex = 13;
            this.LabelClass.Text = "类别";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(31, 21);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(21, 17);
            this.LabelID.TabIndex = 15;
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
            this.ButtonOK.TabIndex = 10;
            this.ButtonOK.Text = "确 定";
            this.ButtonOK.UseVisualStyleBackColor = false;
            // 
            // LabelTotalReserves
            // 
            this.LabelTotalReserves.AutoSize = true;
            this.LabelTotalReserves.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTotalReserves.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelTotalReserves.Location = new System.Drawing.Point(241, 21);
            this.LabelTotalReserves.Name = "LabelTotalReserves";
            this.LabelTotalReserves.Size = new System.Drawing.Size(56, 17);
            this.LabelTotalReserves.TabIndex = 12;
            this.LabelTotalReserves.Text = "总储备量";
            // 
            // LabelCurrentReserve
            // 
            this.LabelCurrentReserve.AutoSize = true;
            this.LabelCurrentReserve.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCurrentReserve.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCurrentReserve.Location = new System.Drawing.Point(424, 21);
            this.LabelCurrentReserve.Name = "LabelCurrentReserve";
            this.LabelCurrentReserve.Size = new System.Drawing.Size(56, 17);
            this.LabelCurrentReserve.TabIndex = 12;
            this.LabelCurrentReserve.Text = "现储备量";
            // 
            // UserControlMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.TextBoxIncrement);
            this.Controls.Add(this.LabelCurrentReserve);
            this.Controls.Add(this.LabelTotalReserves);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.ButtonOK);
            this.Name = "UserControlMaterialList";
            this.Size = new System.Drawing.Size(1014, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIncrement;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelTotalReserves;
        private System.Windows.Forms.Label LabelCurrentReserve;
    }
}
