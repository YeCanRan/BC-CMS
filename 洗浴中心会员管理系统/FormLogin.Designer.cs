namespace 洗浴中心会员管理系统
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.PanelProgressBarContainer = new System.Windows.Forms.Panel();
            this.PanelProgressBar = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxAccount = new System.Windows.Forms.TextBox();
            this.LabelAccount = new System.Windows.Forms.Label();
            this.TimerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.PanelAccount = new System.Windows.Forms.Panel();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelTop.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.PanelProgressBarContainer.SuspendLayout();
            this.PanelAccount.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.PanelTop.Controls.Add(this.LabelTitle);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(484, 80);
            this.PanelTop.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            this.LabelTitle.Location = new System.Drawing.Point(64, 29);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(356, 26);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "欢 迎 使 用 洗 浴 中 心 会 员 管 理 系 统";
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.PanelButton.Controls.Add(this.PanelPassword);
            this.PanelButton.Controls.Add(this.PanelAccount);
            this.PanelButton.Controls.Add(this.PanelProgressBarContainer);
            this.PanelButton.Controls.Add(this.ButtonExit);
            this.PanelButton.Controls.Add(this.ButtonLogin);
            this.PanelButton.Controls.Add(this.LabelPassword);
            this.PanelButton.Controls.Add(this.LabelAccount);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButton.Location = new System.Drawing.Point(0, 80);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(484, 281);
            this.PanelButton.TabIndex = 1;
            // 
            // PanelProgressBarContainer
            // 
            this.PanelProgressBarContainer.Controls.Add(this.PanelProgressBar);
            this.PanelProgressBarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelProgressBarContainer.Location = new System.Drawing.Point(0, 261);
            this.PanelProgressBarContainer.Name = "PanelProgressBarContainer";
            this.PanelProgressBarContainer.Size = new System.Drawing.Size(484, 20);
            this.PanelProgressBarContainer.TabIndex = 5;
            // 
            // PanelProgressBar
            // 
            this.PanelProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.PanelProgressBar.Location = new System.Drawing.Point(1, 1);
            this.PanelProgressBar.Name = "PanelProgressBar";
            this.PanelProgressBar.Size = new System.Drawing.Size(242, 18);
            this.PanelProgressBar.TabIndex = 0;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonExit.Location = new System.Drawing.Point(258, 188);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(175, 36);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "退   出";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonLogin.Location = new System.Drawing.Point(53, 188);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(175, 36);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "登   录";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelPassword.Location = new System.Drawing.Point(49, 101);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(66, 21);
            this.LabelPassword.TabIndex = 0;
            this.LabelPassword.Text = "密   码 :";
            // 
            // TextBoxAccount
            // 
            this.TextBoxAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextBoxAccount.Location = new System.Drawing.Point(5, 3);
            this.TextBoxAccount.MaxLength = 32;
            this.TextBoxAccount.Name = "TextBoxAccount";
            this.TextBoxAccount.Size = new System.Drawing.Size(370, 22);
            this.TextBoxAccount.TabIndex = 1;
            // 
            // LabelAccount
            // 
            this.LabelAccount.AutoSize = true;
            this.LabelAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelAccount.Location = new System.Drawing.Point(49, 17);
            this.LabelAccount.Name = "LabelAccount";
            this.LabelAccount.Size = new System.Drawing.Size(67, 21);
            this.LabelAccount.TabIndex = 0;
            this.LabelAccount.Text = "用户名 :";
            // 
            // TimerProgressBar
            // 
            this.TimerProgressBar.Interval = 10;
            this.TimerProgressBar.Tick += new System.EventHandler(this.TimerProgressBar_Tick);
            // 
            // PanelAccount
            // 
            this.PanelAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.PanelAccount.Controls.Add(this.TextBoxAccount);
            this.PanelAccount.Location = new System.Drawing.Point(53, 47);
            this.PanelAccount.Name = "PanelAccount";
            this.PanelAccount.Size = new System.Drawing.Size(380, 28);
            this.PanelAccount.TabIndex = 6;
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Controls.Add(this.textBox1);
            this.PanelPassword.Location = new System.Drawing.Point(53, 131);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(380, 28);
            this.PanelPassword.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 22);
            this.textBox1.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(100)))));
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextBoxPassword.Location = new System.Drawing.Point(5, 3);
            this.TextBoxPassword.MaxLength = 32;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(370, 22);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelButton.ResumeLayout(false);
            this.PanelButton.PerformLayout();
            this.PanelProgressBarContainer.ResumeLayout(false);
            this.PanelAccount.ResumeLayout(false);
            this.PanelAccount.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxAccount;
        private System.Windows.Forms.Label LabelAccount;
        private System.Windows.Forms.Panel PanelProgressBarContainer;
        private System.Windows.Forms.Panel PanelProgressBar;
        private System.Windows.Forms.Timer TimerProgressBar;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel PanelAccount;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox textBox1;
    }
}