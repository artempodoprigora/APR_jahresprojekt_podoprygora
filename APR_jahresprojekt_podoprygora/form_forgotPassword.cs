using System.Data.SqlClient;
using static APR_jahresprojekt_podoprygora.Sqlmethods;

namespace APR_jahresprojekt_podoprygora
{
    public partial class form_forgotPassword : Form
    {
        public form_forgotPassword()
        {
            InitializeComponent();
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {
            tb_username.Select();
        }

        private void btn_usernameCheck_Click(object sender, EventArgs e)
        {
            if (usernameValidation(tb_username.Text, constring))
            {
                this.btn_usernameCheck.Visible = false;
                this.tb_newPassword.Visible = true;
                this.lb_newPassword.Visible = true;
                this.btn_change.Visible = true;
            }
            else
            {
                MessageBox.Show("Username doesn`t exist!");
            }
        }


        private void btn_change_Click(object sender, EventArgs e)
        {
            if (tb_newPassword.Text.Length >= 8)
            {
                password_change(tb_username.Text, tb_newPassword.Text, constring);
            }
            else if (tb_newPassword.Text.Length < 8)
            {
                MessageBox.Show("Minimal password length is 8 symbols.");
            }
        }

        private void form_forgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Close();
            form_login form_Login = new form_login();
            form_Login.ShowDialog();
            this.Close();
        }

        private void llb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_login form_Login = new form_login();
            form_Login.ShowDialog();
            this.Close();
        }
    }
}
