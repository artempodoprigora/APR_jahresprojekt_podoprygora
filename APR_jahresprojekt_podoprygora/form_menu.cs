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
            this.Hide();
            form_minigame1 form_Minigame1 = new form_minigame1();
            form_Minigame1.ShowDialog();
        }
    }
}
