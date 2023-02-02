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
            char[] spec= { '.', ',', '!', '@', '#', '$', '%', '*' };
            if(password.Length <7 && password.Length >22)
            {
                return false;
            }
            bool haveNum=false,
                haveUpLetter=false,
                haveDownLetter=false,
                haveSpec=false;
            char c;
            if(char.IsDigit(c))
                haveNum true;
            else if(char.IsLower(c))
                haveDownLetter true;
            else if(char.IsUpper(c))
                haveUpLetter true;
            else if(char.IsSymbol(c))
                haveSpec true;


        }
        private void llbNewAkk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authform authform = new Authform();
            authform.Show();
            Hide();
            return;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLoginReg.Text) && !string.IsNullOrEmpty(tbPasswordReg.Text) && !string.IsNullOrEmpty(tbBirth.Text))
            {
                DataTable dataTable = Database.Instance.SqlZapros($"INSERT INTO `Users` (`Login`, `Password`, `Birth`) VALUES ({tbLoginReg.Text}, {tbPasswordReg.Text}, {tbBirth.Text})");
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome!");
                    ProfileUserForm profileUserf = new ProfileUserForm();
                    profileUserf.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }
    }
}
