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
                MessageBox.Show("User with this name already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            bool dr = signup(tb_username.Text, tb_password.Text, constring);
            if (dr)
            {
                User_highscoreSetup(tb_username.Text, constring);
                using (form_login frm = new form_login())
                {

                    frm.ShowDialog();

                }
            }
            else
            {
                return;
            }
        }

        private void llb_AHAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (form_login frm = new form_login())
            {

                frm.ShowDialog();

            }
        }

        private void form_signup_Load(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
