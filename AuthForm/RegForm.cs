using AuthForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthForm
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        public bool ValidatePassword(string password)
        {
            char[] spec = { '.', ',', '!', '@', '#', '$', '%', '*' };
            if (password.Length < 7 && password.Length > 22)
            {
                return false;
            }

            bool haveNum = false,
                haveUpper = false,
                haveLower = false,
                haveSpec = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    haveNum = true;
                else if (char.IsLower(c))
                    haveLower = true;
                else if (char.IsUpper(c))
                    haveUpper = true;
                else if (spec.Any(s => s == c))
                    haveSpec = true;
            }

            return haveNum && haveUpper && haveLower && haveSpec;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int passSeria, passNum;
            if (!string.IsNullOrEmpty(tbLoginReg.Text) && !string.IsNullOrEmpty(tbPasswordReg.Text) && int.TryParse(tbPassportNum.Text, out passNum) && int.TryParse(tbPassportSeria.Text,  out passSeria))
            {
                if(!ValidatePassword(tbPasswordReg.Text))
                {
                    MessageBox.Show("Пароль не валидный!");
                    return;
                }
                if (Database.Instance.SqlZapros($"SELECT * FROM `Users` WHERE `Login`='{tbLoginReg.Text}'").Rows.Count > 0)
                {
                    MessageBox.Show("Этот пользователь уже существует!");
                    return;
                } 

                Database.Instance.NonQuerryZapros($"INSERT INTO `Users` (`Login`, `Password`, `Birth`,`Passport_seria`,`Passport_num`,`Role`) VALUES ('{tbLoginReg.Text}', '{tbPasswordReg.Text}', '{dateTimeBirth.Value.ToString("yyyy-MM-dd")}','{tbPassportSeria.Text}','{tbPassportNum.Text}','2')");
               
                MessageBox.Show("Вы зарегестрированы,войдите в аккаунт!");

                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void dateTimeBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void llbAuth_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authform au = new Authform();
            au.Show();
            Hide();
        }
    }
}
