namespace 洗浴中心会员管理系统
{
    partial class FormMemberInformation
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
            this.ButtonSearchByTel = new System.Windows.Forms.Button();
            this.TextBoxTel = new System.Windows.Forms.TextBox();
            this.ButtonSearchByCardNumber = new System.Windows.Forms.Button();
            this.LabelTel = new System.Windows.Forms.Label();
            this.TextBoxCardNumber = new System.Windows.Forms.TextBox();
            this.LabelCardNumber = new System.Windows.Forms.Label();
            this.PanelMemberList = new System.Windows.Forms.Panel();
            this.PanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelSearch.Controls.Add(this.ButtonClear);
            this.PanelSearch.Controls.Add(this.ButtonSearchByTel);
            this.PanelSearch.Controls.Add(this.TextBoxTel);
            this.PanelSearch.Controls.Add(this.ButtonSearchByCardNumber);
            this.PanelSearch.Controls.Add(this.LabelTel);
            this.PanelSearch.Controls.Add(this.TextBoxCardNumber);
            this.PanelSearch.Controls.Add(this.LabelCardNumber);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(1014, 101);
            this.PanelSearch.TabIndex = 1;
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
            // ButtonSearchByTel
            // 
            this.ButtonSearchByTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSearchByTel.FlatAppearance.BorderSize = 0;
            this.ButtonSearchByTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchByTel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSearchByTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSearchByTel.Location = new System.Drawing.Point(652, 39);
            this.ButtonSearchByTel.Name = "ButtonSearchByTel";
            this.ButtonSearchByTel.Size = new System.Drawing.Size(80, 28);
            this.ButtonSearchByTel.TabIndex = 2;
            this.ButtonSearchByTel.Text = "电话号检索";
            this.ButtonSearchByTel.UseVisualStyleBackColor = false;
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
            // ButtonSearchByCardNumber
            // 
            this.ButtonSearchByCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSearchByCardNumber.FlatAppearance.BorderSize = 0;
            this.ButtonSearchByCardNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchByCardNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSearchByCardNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSearchByCardNumber.Location = new System.Drawing.Point(296, 39);
            this.ButtonSearchByCardNumber.Name = "ButtonSearchByCardNumber";
            this.ButtonSearchByCardNumber.Size = new System.Drawing.Size(65, 28);
            this.ButtonSearchByCardNumber.TabIndex = 2;
            this.ButtonSearchByCardNumber.Text = "卡号检索";
            this.ButtonSearchByCardNumber.UseVisualStyleBackColor = false;
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
            // TextBoxCardNumber
            // 
            this.TextBoxCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCardNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxCardNumber.Location = new System.Drawing.Point(111, 44);
            this.TextBoxCardNumber.Name = "TextBoxCardNumber";
            this.TextBoxCardNumber.Size = new System.Drawing.Size(168, 19);
            this.TextBoxCardNumber.TabIndex = 1;
            // 
            // LabelCardNumber
            // 
            this.LabelCardNumber.AutoSize = true;
            this.LabelCardNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCardNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCardNumber.Location = new System.Drawing.Point(22, 43);
            this.LabelCardNumber.Name = "LabelCardNumber";
            this.LabelCardNumber.Size = new System.Drawing.Size(72, 20);
            this.LabelCardNumber.TabIndex = 0;
            this.LabelCardNumber.Text = "会员卡号 :";
            // 
            // PanelMemberList
            // 
            this.PanelMemberList.AutoScroll = true;
            this.PanelMemberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMemberList.Location = new System.Drawing.Point(0, 101);
            this.PanelMemberList.Name = "PanelMemberList";
            this.PanelMemberList.Size = new System.Drawing.Size(1014, 580);
            this.PanelMemberList.TabIndex = 2;
            // 
            // FormMemberInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelMemberList);
            this.Controls.Add(this.PanelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMemberInformation";
            this.Text = "FormMemberInfo";
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSearchByCardNumber;
        private System.Windows.Forms.TextBox TextBoxCardNumber;
        private System.Windows.Forms.Label LabelCardNumber;
        private System.Windows.Forms.Panel PanelMemberList;
        private System.Windows.Forms.Button ButtonSearchByTel;
        private System.Windows.Forms.TextBox TextBoxTel;
        private System.Windows.Forms.Label LabelTel;
    }
}