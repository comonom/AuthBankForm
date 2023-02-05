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
    public partial class Authform : Form
    {
        private int CountBadTries = 0;
        public Authform()
        {
            InitializeComponent();
        }
          
        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BlockedToDate > DateTime.Now)
            {
                MessageBox.Show($"Количество неудачных попыток превышено, вы заблокированы ещё {(Properties.Settings.Default.BlockedToDate - DateTime.Now).TotalSeconds} сек.");
                return;
            }
            if(!string.IsNullOrEmpty(tbLogin.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                DataTable table = Database.Instance.SqlZapros($"SELECT * FROM `Users` WHERE `Login`='{tbLogin.Text}' AND `Password`='{tbPassword.Text}'");
                if (table.Rows.Count > 0)
                {
                    User.localuser = new User(table.Rows[0]);
                    ProfileUserForm profileUserf = new ProfileUserForm();
                    profileUserf.Show();
                    Hide();
                }
                else
                {
                    CountBadTries++;
                    if (CountBadTries >= 3)
                    {
                        DateTime blockTime = DateTime.Now.AddMinutes(1);
                        Properties.Settings.Default.BlockedToDate = blockTime;
                        Properties.Settings.Default.Save();
                        CountBadTries = 0;
                        MessageBox.Show("Количество неудачных попыток превышено, вы заблокированы до:" + blockTime);
                        return;
                    }
                    MessageBox.Show("Пользователя не существует!");

                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void llbNewAkk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RegForm regForm = new RegForm();
            Hide();
            regForm.ShowDialog();
            Show();
        }

    }
}
