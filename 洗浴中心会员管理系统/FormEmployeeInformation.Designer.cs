namespace 洗浴中心会员管理系统
{
    partial class FormEmployeeInformation
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
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSearchByTel = new System.Windows.Forms.Button();
            this.TextBoxTel = new System.Windows.Forms.TextBox();
            this.ButtonSearchByEmployeeNo = new System.Windows.Forms.Button();
            this.LabelTel = new System.Windows.Forms.Label();
            this.TextBoxEmployeeNo = new System.Windows.Forms.TextBox();
            this.LabelEmployeeNo = new System.Windows.Forms.Label();
            this.PanelEmployeeList = new System.Windows.Forms.Panel();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelHead.Controls.Add(this.ButtonClear);
            this.PanelHead.Controls.Add(this.ButtonSearchByTel);
            this.PanelHead.Controls.Add(this.TextBoxTel);
            this.PanelHead.Controls.Add(this.ButtonSearchByEmployeeNo);
            this.PanelHead.Controls.Add(this.LabelTel);
            this.PanelHead.Controls.Add(this.TextBoxEmployeeNo);
            this.PanelHead.Controls.Add(this.LabelEmployeeNo);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1014, 101);
            this.PanelHead.TabIndex = 2;
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
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "清 除";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSearchByTel
            // 
            this.ButtonSearchByTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSearchByTel.FlatAppearance.BorderSize = 0;
            this.ButtonSearchByTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchByTel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSearchByTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSearchByTel.Location = new System.Drawing.Point(666, 35);
            this.ButtonSearchByTel.Name = "ButtonSearchByTel";
            this.ButtonSearchByTel.Size = new System.Drawing.Size(80, 28);
            this.ButtonSearchByTel.TabIndex = 4;
            this.ButtonSearchByTel.Text = "电话号检索";
            this.ButtonSearchByTel.UseVisualStyleBackColor = false;
            this.ButtonSearchByTel.Click += new System.EventHandler(this.ButtonSearchByTel_Click);
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxTel.Location = new System.Drawing.Point(480, 40);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(168, 19);
            this.TextBoxTel.TabIndex = 3;
            // 
            // ButtonSearchByEmployeeNo
            // 
            this.ButtonSearchByEmployeeNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSearchByEmployeeNo.FlatAppearance.BorderSize = 0;
            this.ButtonSearchByEmployeeNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchByEmployeeNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSearchByEmployeeNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSearchByEmployeeNo.Location = new System.Drawing.Point(291, 35);
            this.ButtonSearchByEmployeeNo.Name = "ButtonSearchByEmployeeNo";
            this.ButtonSearchByEmployeeNo.Size = new System.Drawing.Size(65, 28);
            this.ButtonSearchByEmployeeNo.TabIndex = 2;
            this.ButtonSearchByEmployeeNo.Text = "编号检索";
            this.ButtonSearchByEmployeeNo.UseVisualStyleBackColor = false;
            this.ButtonSearchByEmployeeNo.Click += new System.EventHandler(this.ButtonSearchByEmployeeNo_Click);
            // 
            // LabelTel
            // 
            this.LabelTel.AutoSize = true;
            this.LabelTel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelTel.Location = new System.Drawing.Point(402, 39);
            this.LabelTel.Name = "LabelTel";
            this.LabelTel.Size = new System.Drawing.Size(72, 20);
            this.LabelTel.TabIndex = 0;
            this.LabelTel.Text = "电话号码 :";
            // 
            // TextBoxEmployeeNo
            // 
            this.TextBoxEmployeeNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmployeeNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEmployeeNo.Location = new System.Drawing.Point(105, 40);
            this.TextBoxEmployeeNo.Name = "TextBoxEmployeeNo";
            this.TextBoxEmployeeNo.Size = new System.Drawing.Size(168, 19);
            this.TextBoxEmployeeNo.TabIndex = 1;
            // 
            // LabelEmployeeNo
            // 
            this.LabelEmployeeNo.AutoSize = true;
            this.LabelEmployeeNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelEmployeeNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelEmployeeNo.Location = new System.Drawing.Point(27, 39);
            this.LabelEmployeeNo.Name = "LabelEmployeeNo";
            this.LabelEmployeeNo.Size = new System.Drawing.Size(72, 20);
            this.LabelEmployeeNo.TabIndex = 0;
            this.LabelEmployeeNo.Text = "员工编号 :";
            // 
            // PanelEmployeeList
            // 
            this.PanelEmployeeList.AutoScroll = true;
            this.PanelEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEmployeeList.Location = new System.Drawing.Point(0, 101);
            this.PanelEmployeeList.Name = "PanelEmployeeList";
            this.PanelEmployeeList.Size = new System.Drawing.Size(1014, 580);
            this.PanelEmployeeList.TabIndex = 3;
            // 
            // FormEmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelEmployeeList);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeInformation";
            this.Text = "FormEmployeeInformation";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSearchByTel;
        private System.Windows.Forms.TextBox TextBoxTel;
        private System.Windows.Forms.Button ButtonSearchByEmployeeNo;
        private System.Windows.Forms.Label LabelTel;
        private System.Windows.Forms.TextBox TextBoxEmployeeNo;
        private System.Windows.Forms.Label LabelEmployeeNo;
        private System.Windows.Forms.Panel PanelEmployeeList;
    }
}