
namespace AuthForm
{
    partial class Authform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbNewAkk = new System.Windows.Forms.LinkLabel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llbNewAkk);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.btnAuth);
            this.groupBox1.Location = new System.Drawing.Point(125, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // llbNewAkk
            // 
            this.llbNewAkk.AutoSize = true;
            this.llbNewAkk.Location = new System.Drawing.Point(103, 230);
            this.llbNewAkk.Name = "llbNewAkk";
            this.llbNewAkk.Size = new System.Drawing.Size(92, 13);
            this.llbNewAkk.TabIndex = 5;
            this.llbNewAkk.TabStop = true;
            this.llbNewAkk.Text = "Создать аккаунт";
            this.llbNewAkk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbNewAkk_LinkClicked);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(121, 113);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(142, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(121, 67);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(142, 20);
            this.tbLogin.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(21, 116);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(21, 60);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(38, 13);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Логин";
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(106, 188);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(89, 23);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // Authform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Authform";
            this.Text = "Авторизация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llbNewAkk;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnAuth;
    }
}

