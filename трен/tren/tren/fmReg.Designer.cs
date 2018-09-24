namespace tren
{
    partial class fmReg
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
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.tbPwd2 = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(197, 251);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(289, 30);
            this.tbPwd.TabIndex = 3;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(197, 191);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(289, 30);
            this.tbLogin.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(109, 254);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 26);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Пароль:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(121, 194);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 26);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Логин:";
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Location = new System.Drawing.Point(129, 141);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(62, 26);
            this.lblFIO.TabIndex = 5;
            this.lblFIO.Text = "ФИО:";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(197, 137);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(289, 30);
            this.tbFIO.TabIndex = 1;
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.Location = new System.Drawing.Point(14, 310);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(177, 26);
            this.lblPwd2.TabIndex = 4;
            this.lblPwd2.Text = "Повторите пароль:";
            // 
            // tbPwd2
            // 
            this.tbPwd2.Location = new System.Drawing.Point(197, 307);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.Size = new System.Drawing.Size(289, 30);
            this.tbPwd2.TabIndex = 4;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(207, 413);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(226, 60);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // fmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(604, 761);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbPwd2);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPwd2);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.fmReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.TextBox tbPwd2;
        private System.Windows.Forms.Button btnReg;
    }
}