﻿namespace 洗浴中心会员管理系统
{
    partial class FormMaterialManagement
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
            this.LabelIncrement = new System.Windows.Forms.Label();
            this.LabelCurrentReserve = new System.Windows.Forms.Label();
            this.LabelTotalReserves = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.PanelMaterialList = new System.Windows.Forms.Panel();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelHead.Controls.Add(this.LabelIncrement);
            this.PanelHead.Controls.Add(this.LabelCurrentReserve);
            this.PanelHead.Controls.Add(this.LabelTotalReserves);
            this.PanelHead.Controls.Add(this.LabelClass);
            this.PanelHead.Controls.Add(this.LabelID);
            this.PanelHead.Controls.Add(this.ButtonSubmit);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1014, 100);
            this.PanelHead.TabIndex = 8;
            // 
            // LabelIncrement
            // 
            this.LabelIncrement.AutoSize = true;
            this.LabelIncrement.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelIncrement.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelIncrement.Location = new System.Drawing.Point(606, 39);
            this.LabelIncrement.Name = "LabelIncrement";
            this.LabelIncrement.Size = new System.Drawing.Size(37, 20);
            this.LabelIncrement.TabIndex = 8;
            this.LabelIncrement.Text = "增量";
            // 
            // LabelCurrentReserve
            // 
            this.LabelCurrentReserve.AutoSize = true;
            this.LabelCurrentReserve.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCurrentReserve.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCurrentReserve.Location = new System.Drawing.Point(421, 39);
            this.LabelCurrentReserve.Name = "LabelCurrentReserve";
            this.LabelCurrentReserve.Size = new System.Drawing.Size(65, 20);
            this.LabelCurrentReserve.TabIndex = 9;
            this.LabelCurrentReserve.Text = "现储备量";
            // 
            // LabelTotalReserves
            // 
            this.LabelTotalReserves.AutoSize = true;
            this.LabelTotalReserves.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTotalReserves.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelTotalReserves.Location = new System.Drawing.Point(236, 39);
            this.LabelTotalReserves.Name = "LabelTotalReserves";
            this.LabelTotalReserves.Size = new System.Drawing.Size(65, 20);
            this.LabelTotalReserves.TabIndex = 10;
            this.LabelTotalReserves.Text = "总储备量";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelClass.Location = new System.Drawing.Point(79, 39);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(37, 20);
            this.LabelClass.TabIndex = 11;
            this.LabelClass.Text = "类别";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelID.Location = new System.Drawing.Point(28, 39);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(24, 20);
            this.LabelID.TabIndex = 12;
            this.LabelID.Text = "ID";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ButtonSubmit.FlatAppearance.BorderSize = 0;
            this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSubmit.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSubmit.Location = new System.Drawing.Point(893, 34);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(80, 30);
            this.ButtonSubmit.TabIndex = 1;
            this.ButtonSubmit.Text = "提 交";
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            // 
            // PanelMaterialList
            // 
            this.PanelMaterialList.AutoScroll = true;
            this.PanelMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMaterialList.Location = new System.Drawing.Point(0, 100);
            this.PanelMaterialList.Name = "PanelMaterialList";
            this.PanelMaterialList.Size = new System.Drawing.Size(1014, 581);
            this.PanelMaterialList.TabIndex = 9;
            // 
            // FormMaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.PanelMaterialList);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaterialManagement";
            this.Text = "FormMaterialManagement";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Panel PanelMaterialList;
        private System.Windows.Forms.Label LabelIncrement;
        private System.Windows.Forms.Label LabelCurrentReserve;
        private System.Windows.Forms.Label LabelTotalReserves;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label LabelID;
    }
}