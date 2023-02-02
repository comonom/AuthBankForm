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
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Authform authForm = new Authform();
            authForm.Show();
            Hide();
            return;
        }

        private void ProfileUser_Load(object sender, EventArgs e)
        {

        }
    }
}
