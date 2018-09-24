namespace tren
{
    partial class fmAutorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVhod = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVhod
            // 
            this.btnVhod.Location = new System.Drawing.Point(217, 378);
            this.btnVhod.Name = "btnVhod";
            this.btnVhod.Size = new System.Drawing.Size(189, 59);
            this.btnVhod.TabIndex = 3;
            this.btnVhod.Text = "Войти";
            this.btnVhod.UseVisualStyleBackColor = true;
            this.btnVhod.Click += new System.EventHandler(this.btnVhod_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(141, 233);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 26);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(129, 293);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 26);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Пароль:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(217, 230);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(237, 30);
            this.tbLogin.TabIndex = 1;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(217, 290);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(237, 30);
            this.tbPwd.TabIndex = 2;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(217, 465);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(189, 59);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(185, 159);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(244, 26);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Введите данные для входа:";
            // 
            // fmAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(604, 761);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnVhod);
            this.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fmAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVhod;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblInfo;
    }
}

