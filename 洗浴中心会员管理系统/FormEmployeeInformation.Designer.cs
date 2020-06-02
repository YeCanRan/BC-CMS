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
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSearchByTelNumber = new System.Windows.Forms.Button();
            this.TextBoxTel = new System.Windows.Forms.TextBox();
            this.ButtonSearchByEmployeeNumber = new System.Windows.Forms.Button();
            this.LabelTel = new System.Windows.Forms.Label();
            this.TextBoxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.LabelEmployeeNumber = new System.Windows.Forms.Label();
            this.PanelEmployeeList = new System.Windows.Forms.Panel();
            this.PanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelSearch.Controls.Add(this.ButtonClear);
            this.PanelSearch.Controls.Add(this.ButtonSearchByTelNumber);
            this.PanelSearch.Controls.Add(this.TextBoxTel);
            this.PanelSearch.Controls.Add(this.ButtonSearchByEmployeeNumber);
            this.PanelSearch.Controls.Add(this.LabelTel);
            this.PanelSearch.Controls.Add(this.TextBoxEmployeeNumber);
            this.PanelSearch.Controls.Add(this.LabelEmployeeNumber);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(1014, 101);
            this.PanelSearch.TabIndex = 2;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonClear.Location = new System.Drawing.Point(922, 39);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(65, 28);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "清 除";
            this.ButtonClear.UseVisualStyleBackColor = false;
            // 
            // ButtonSearchByTelNumber
            // 
            this.ButtonSearchByTelNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSearchByTelNumber.FlatAppearance.BorderSize = 0;
            this.ButtonSearchByTelNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchByTelNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSearchByTelNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSearchByTelNumber.Location = new System.Drawing.Point(652, 39);
            this.ButtonSearchByTelNumber.Name = "ButtonSearchByTelNumber";
            this.ButtonSearchByTelNumber.Size = new System.Drawing.Size(80, 28);
            this.ButtonSearchByTelNumber.TabIndex = 2;
            this.ButtonSearchByTelNumber.Text = "电话号检索";
            this.ButtonSearchByTelNumber.UseVisualStyleBackColor = false;
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxTel.Location = new System.Drawing.Point(467, 44);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(168, 19);
            this.TextBoxTel.TabIndex = 1;
            // 
            // ButtonSearchByEmployeeNumber
            // 
            this.ButtonSearchByEmployeeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSearchByEmployeeNumber.FlatAppearance.BorderSize = 0;
            this.ButtonSearchByEmployeeNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchByEmployeeNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSearchByEmployeeNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSearchByEmployeeNumber.Location = new System.Drawing.Point(296, 39);
            this.ButtonSearchByEmployeeNumber.Name = "ButtonSearchByEmployeeNumber";
            this.ButtonSearchByEmployeeNumber.Size = new System.Drawing.Size(65, 28);
            this.ButtonSearchByEmployeeNumber.TabIndex = 2;
            this.ButtonSearchByEmployeeNumber.Text = "编号检索";
            this.ButtonSearchByEmployeeNumber.UseVisualStyleBackColor = false;
            // 
            // LabelTel
            // 
            this.LabelTel.AutoSize = true;
            this.LabelTel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelTel.Location = new System.Drawing.Point(378, 43);
            this.LabelTel.Name = "LabelTel";
            this.LabelTel.Size = new System.Drawing.Size(72, 20);
            this.LabelTel.TabIndex = 0;
            this.LabelTel.Text = "电话号码 :";
            // 
            // TextBoxEmployeeNumber
            // 
            this.TextBoxEmployeeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmployeeNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEmployeeNumber.Location = new System.Drawing.Point(111, 44);
            this.TextBoxEmployeeNumber.Name = "TextBoxEmployeeNumber";
            this.TextBoxEmployeeNumber.Size = new System.Drawing.Size(168, 19);
            this.TextBoxEmployeeNumber.TabIndex = 1;
            // 
            // LabelEmployeeNumber
            // 
            this.LabelEmployeeNumber.AutoSize = true;
            this.LabelEmployeeNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelEmployeeNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelEmployeeNumber.Location = new System.Drawing.Point(22, 43);
            this.LabelEmployeeNumber.Name = "LabelEmployeeNumber";
            this.LabelEmployeeNumber.Size = new System.Drawing.Size(72, 20);
            this.LabelEmployeeNumber.TabIndex = 0;
            this.LabelEmployeeNumber.Text = "员工编号 :";
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
            this.Controls.Add(this.PanelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeInformation";
            this.Text = "FormEmployeeInformation";
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSearchByTelNumber;
        private System.Windows.Forms.TextBox TextBoxTel;
        private System.Windows.Forms.Button ButtonSearchByEmployeeNumber;
        private System.Windows.Forms.Label LabelTel;
        private System.Windows.Forms.TextBox TextBoxEmployeeNumber;
        private System.Windows.Forms.Label LabelEmployeeNumber;
        private System.Windows.Forms.Panel PanelEmployeeList;
    }
}