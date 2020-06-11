namespace 洗浴中心会员管理系统
{
    partial class FormLeaflet
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelNumbers = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.TextBoxNumbers = new System.Windows.Forms.TextBox();
            this.LabelLeaflet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCancel.Location = new System.Drawing.Point(913, 13);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 30);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "取 消";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonOK.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonOK.Location = new System.Drawing.Point(823, 13);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(80, 30);
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "确 定";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelNumbers
            // 
            this.LabelNumbers.AutoSize = true;
            this.LabelNumbers.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelNumbers.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNumbers.Location = new System.Drawing.Point(220, 20);
            this.LabelNumbers.Name = "LabelNumbers";
            this.LabelNumbers.Size = new System.Drawing.Size(43, 17);
            this.LabelNumbers.TabIndex = 10;
            this.LabelNumbers.Text = "数 量 :";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelClass.Location = new System.Drawing.Point(31, 20);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(43, 17);
            this.LabelClass.TabIndex = 11;
            this.LabelClass.Text = "类 别 :";
            // 
            // TextBoxNumbers
            // 
            this.TextBoxNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNumbers.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxNumbers.Location = new System.Drawing.Point(269, 17);
            this.TextBoxNumbers.Name = "TextBoxNumbers";
            this.TextBoxNumbers.Size = new System.Drawing.Size(129, 22);
            this.TextBoxNumbers.TabIndex = 12;
            // 
            // LabelLeaflet
            // 
            this.LabelLeaflet.AutoSize = true;
            this.LabelLeaflet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLeaflet.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelLeaflet.Location = new System.Drawing.Point(80, 20);
            this.LabelLeaflet.Name = "LabelLeaflet";
            this.LabelLeaflet.Size = new System.Drawing.Size(44, 17);
            this.LabelLeaflet.TabIndex = 11;
            this.LabelLeaflet.Text = "宣传券";
            // 
            // FormLeaflet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1014, 58);
            this.Controls.Add(this.TextBoxNumbers);
            this.Controls.Add(this.LabelNumbers);
            this.Controls.Add(this.LabelLeaflet);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLeaflet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLeaflet";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLeaflet_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelNumbers;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.TextBox TextBoxNumbers;
        private System.Windows.Forms.Label LabelLeaflet;
    }
}