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
    public partial class ProfileUserForm : Form
    {
        public ProfileUserForm()
        {
            InitializeComponent();
            lbLogUser.Text = $"Логин: {User.localuser.Login}";
            lbNumUser.Text = $"Номер паспорта: {User.localuser.Passport_num}";
            lbSeriaUser.Text = $"Серия паспорта: {User.localuser.Passport_seria}";
            lbBirthUser.Text = $"Дата рождения: {User.localuser.Birth}";
            lbRoleUser.Text = $"Роль: {User.GetRoleName(User.localuser.Role)}";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            User.localuser = null;
            Authform authForm = new Authform();
            authForm.Show();
            Hide();
            return;
        }


    }
}
