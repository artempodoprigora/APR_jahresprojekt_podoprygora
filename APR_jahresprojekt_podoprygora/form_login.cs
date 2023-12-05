using static APR_jahresprojekt_podoprygora.Sqlmethods;
using System.Data.SqlClient;

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

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validation(tb_username.Text, tb_password.Text, constring))
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Fail!((");
            }
        }
    }
}
