
namespace AuthForm
{
    partial class RegForm
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
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.llbNewAkk = new System.Windows.Forms.LinkLabel();
            this.tbLoginReg = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Location = new System.Drawing.Point(122, 88);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.Size = new System.Drawing.Size(142, 20);
            this.tbPasswordReg.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(13, 95);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(13, 32);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(38, 13);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Логин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBirth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.llbNewAkk);
            this.groupBox1.Controls.Add(this.tbPasswordReg);
            this.groupBox1.Controls.Add(this.tbLoginReg);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(122, 129);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(142, 20);
            this.tbBirth.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения";
            // 
            // llbNewAkk
            // 
            this.llbNewAkk.AutoSize = true;
            this.llbNewAkk.Location = new System.Drawing.Point(128, 237);
            this.llbNewAkk.Name = "llbNewAkk";
            this.llbNewAkk.Size = new System.Drawing.Size(37, 13);
            this.llbNewAkk.TabIndex = 5;
            this.llbNewAkk.TabStop = true;
            this.llbNewAkk.Text = "Войти";
            this.llbNewAkk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbNewAkk_LinkClicked);
            // 
            // tbLoginReg
            // 
            this.tbLoginReg.Location = new System.Drawing.Point(122, 32);
            this.tbLoginReg.Name = "tbLoginReg";
            this.tbLoginReg.Size = new System.Drawing.Size(142, 20);
            this.tbLoginReg.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(105, 191);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(89, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPasswordReg;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbNewAkk;
        private System.Windows.Forms.TextBox tbLoginReg;
        private System.Windows.Forms.Button btnCreate;
    }
}