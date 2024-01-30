using System.Data.SqlClient;
using static APR_jahresprojekt_podoprygora.Sqlmethods;

namespace APR_jahresprojekt_podoprygora
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            create_database_jahresprojektDB(constring);
            create_table_login(constring);
            create_table_highscore(constring);
            tb_username.Select();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validation(tb_username.Text, tb_password.Text, constring))
            {
                session_username = tb_username.Text;
                User_highscoreSetup(session_username, constring);
                this.Hide();
                form_menu form_Menu = new form_menu();
                form_Menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }

        private void llb_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form_forgotPassword form_ForgotPassword = new form_forgotPassword();
            form_ForgotPassword.ShowDialog();
        }

        private void lb_password_Click(object sender, EventArgs e)
        {

        }

        private void llb_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form_signup form_Signup = new form_signup();
            form_Signup.ShowDialog();
        }
    }
}
