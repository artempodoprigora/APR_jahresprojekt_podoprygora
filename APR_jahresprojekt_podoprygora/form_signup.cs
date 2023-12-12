using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APR_jahresprojekt_podoprygora.Sqlmethods;

namespace APR_jahresprojekt_podoprygora
{
    public partial class form_signup : Form
    {
        public form_signup()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!usernameValidation(tb_username.Text, constring))
            {
                lb_password.Visible = true;
                tb_password.Visible = true;
                btn_signup.Visible = true;
                btn_next.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            signup(tb_username.Text, tb_password.Text, constring);
        }

        private void llb_AHAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form_login form_Login = new form_login();
            form_Login.ShowDialog();
        }
    }
}
