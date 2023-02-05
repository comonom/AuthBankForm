
namespace AuthForm
{
    partial class ProfileUserForm
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
            this.lbLogUser = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.lbSeriaUser = new System.Windows.Forms.Label();
            this.lbNumUser = new System.Windows.Forms.Label();
            this.lbBirthUser = new System.Windows.Forms.Label();
            this.lbRoleUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLogUser
            // 
            this.lbLogUser.AutoSize = true;
            this.lbLogUser.Location = new System.Drawing.Point(20, 34);
            this.lbLogUser.Name = "lbLogUser";
            this.lbLogUser.Size = new System.Drawing.Size(38, 13);
            this.lbLogUser.TabIndex = 0;
            this.lbLogUser.Text = "Логин";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(183, 296);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 28);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Выйти";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lbSeriaUser
            // 
            this.lbSeriaUser.AutoSize = true;
            this.lbSeriaUser.Location = new System.Drawing.Point(20, 117);
            this.lbSeriaUser.Name = "lbSeriaUser";
            this.lbSeriaUser.Size = new System.Drawing.Size(88, 13);
            this.lbSeriaUser.TabIndex = 3;
            this.lbSeriaUser.Text = "Серия паспорта";
            // 
            // lbNumUser
            // 
            this.lbNumUser.AutoSize = true;
            this.lbNumUser.Location = new System.Drawing.Point(20, 168);
            this.lbNumUser.Name = "lbNumUser";
            this.lbNumUser.Size = new System.Drawing.Size(91, 13);
            this.lbNumUser.TabIndex = 4;
            this.lbNumUser.Text = "Номер паспорта";
            // 
            // lbBirthUser
            // 
            this.lbBirthUser.AutoSize = true;
            this.lbBirthUser.Location = new System.Drawing.Point(20, 79);
            this.lbBirthUser.Name = "lbBirthUser";
            this.lbBirthUser.Size = new System.Drawing.Size(86, 13);
            this.lbBirthUser.TabIndex = 10;
            this.lbBirthUser.Text = "Дата рождения";
            // 
            // lbRoleUser
            // 
            this.lbRoleUser.AutoSize = true;
            this.lbRoleUser.Location = new System.Drawing.Point(20, 214);
            this.lbRoleUser.Name = "lbRoleUser";
            this.lbRoleUser.Size = new System.Drawing.Size(32, 13);
            this.lbRoleUser.TabIndex = 11;
            this.lbRoleUser.Text = "Роль";
            // 
            // ProfileUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 336);
            this.Controls.Add(this.lbRoleUser);
            this.Controls.Add(this.lbBirthUser);
            this.Controls.Add(this.lbNumUser);
            this.Controls.Add(this.lbSeriaUser);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lbLogUser);
            this.Name = "ProfileUserForm";
            this.Text = "ProfileUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogUser;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lbSeriaUser;
        private System.Windows.Forms.Label lbNumUser;
        private System.Windows.Forms.Label lbBirthUser;
        private System.Windows.Forms.Label lbRoleUser;
    }
}