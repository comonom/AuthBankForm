﻿using System;
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
        public Authform()
        {
            InitializeComponent();
        }

        /*if(lbLogin=tbLogin.Text && lbPassword=tbPassword.Text)*/
          
        private void btnAuth_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbLogin.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                DataTable table = Database.Instance.SqlZapros($"SELECT * FROM `Users` WHERE `Login`='{tbLogin.Text}' AND `Password`='{tbPassword.Text}'");
                if (table.Rows.Count > 0)
                {
                    ProfileUserForm profileUserf = new ProfileUserForm();
                    profileUserf.Show();
                    Hide();
                }
                else
                {
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
            regForm.Show();
            Hide();
            return;
        }

    }
}