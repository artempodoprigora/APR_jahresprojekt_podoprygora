using System.Windows.Forms;
using static APR_jahresprojekt_podoprygora.Sqlmethods;

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
            using (form_minigame1 frm = new form_minigame1())
            {
                frm.ShowDialog();
                this.Hide();
            }
        }

        private void form_menu_Load(object sender, EventArgs e)
        {
            getHighscoreUsernameList(lb_highscoreUsername, constring);
            getHighscoreList(lb_highscoreList, constring);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            form_minigame1 frm = new form_minigame1();
            this.Hide();
            frm.ShowDialog();
        }

        private void llb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_login frm = new form_login();
            this.Hide();
            frm.ShowDialog();
            
        }
    }
}
