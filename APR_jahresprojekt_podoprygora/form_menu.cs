using System.Windows.Forms;

namespace APR_jahresprojekt_podoprygora
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void logo_game1_Click(object sender, EventArgs e)
        {
            using(form_minigame1 frm = new form_minigame1())
                {
                this.Hide();
                frm.ShowDialog();

            }
        }

        private void form_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
