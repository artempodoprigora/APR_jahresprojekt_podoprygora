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
    public partial class form_minigame1 : Form
    {
        public form_minigame1()
        {
            InitializeComponent();
        }

        private void form_minigame1_Load(object sender, EventArgs e)
        {
            highscore(session_username, lb_highscore, constring);
        }
    }
}
