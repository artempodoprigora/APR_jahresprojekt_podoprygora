using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APR_jahresprojekt_podoprygora.Sqlmethods;


namespace APR_jahresprojekt_podoprygora
{
    public partial class form_minigame1 : Form
    {

        public int[,] field = new int[4, 4];
        public System.Windows.Forms.Label[,] number = new System.Windows.Forms.Label[4, 4];
        public PictureBox[,] pictures = new PictureBox[4, 4];
        private int score = 0;

        public form_minigame1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(KeyPressed);
            field[0, 0] = 1;
            field[0, 1] = 1;
            InitializeField();
            InitializePictures();
            CreateNewPicture();
        }

        public void form_minigame1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeField()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(12 + 56 * j, 73 + 56 * i);
                    pic.Size = new Size(50, 50);
                    pic.BackColor = Color.Gray;
                    this.Controls.Add(pic);
                }
            }
        }

        private void CreateNewPicture()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);
            while (pictures[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }
            field[a, b] = 1;
            pictures[a, b] = new PictureBox();
            number[a, b] = new System.Windows.Forms.Label();
            number[a, b].Text = "2";
            number[a, b].Size = new Size(50, 50);
            number[a, b].TextAlign = ContentAlignment.MiddleCenter;
            number[a, b].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pictures[a, b].Controls.Add(number[a, b]);
            pictures[a, b].Location = new Point(12 + b * 56, 73 + 56 * a);
            pictures[a, b].Size = new Size(50, 50);
            pictures[a, b].BackColor = Color.Yellow;
            this.Controls.Add(pictures[a, b]);
            pictures[a, b].BringToFront();
        }

        private void InitializePictures()
        {
            pictures[0, 0] = new PictureBox();
            number[0, 0] = new System.Windows.Forms.Label();
            number[0, 0].Text = "2";
            number[0, 0].Size = new Size(50, 50);
            number[0, 0].TextAlign = ContentAlignment.MiddleCenter;
            number[0, 0].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pictures[0, 0].Controls.Add(number[0, 0]);
            pictures[0, 0].Location = new Point(12, 73);
            pictures[0, 0].Size = new Size(50, 50);
            pictures[0, 0].BackColor = Color.Yellow;
            this.Controls.Add(pictures[0, 0]);
            pictures[0, 0].BringToFront();

            pictures[0, 1] = new PictureBox();
            number[0, 1] = new System.Windows.Forms.Label();
            number[0, 1].Text = "2";
            number[0, 1].Size = new Size(50, 50);
            number[0, 1].TextAlign = ContentAlignment.MiddleCenter;
            number[0, 1].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pictures[0, 1].Controls.Add(number[0, 1]);
            pictures[0, 1].Location = new Point(68, 73);
            pictures[0, 1].Size = new Size(50, 50);
            pictures[0, 1].BackColor = Color.Yellow;
            this.Controls.Add(pictures[0, 1]);
            pictures[0, 1].BringToFront();
        }

        private void ChangeColor(int num, int x, int y)
        {
            switch (num)
            {
                case 8:
                    pictures[x, y].BackColor = Color.Maroon;
                    break;
                case 16:
                    pictures[x, y].BackColor = Color.Cyan;
                    break;
                case 32:
                    pictures[x, y].BackColor = Color.Coral;
                    break;
                case 64:
                    pictures[x, y].BackColor = Color.Brown;
                    break;
                case 128:
                    pictures[x, y].BackColor = Color.Blue;
                    break;
                case 256:
                    pictures[x, y].BackColor = Color.DarkViolet;
                    break;
                case 512:
                    pictures[x, y].BackColor = Color.Red;
                    break;
                case 1024:
                    pictures[x, y].BackColor = Color.Pink;
                    break;
                default:
                    pictures[x, y].BackColor = Color.Green;
                    break;

            }
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            bool ifPicWasMoved = false;
            ProcessDialogKey(e.KeyCode);
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int x = 0; x < 4; x++)
                    {
                        for (int i = 2; i >= 0; i--)
                        {
                            if (field[x, i] == 1)
                            {
                                for (int y = i + 1; y < 4; y++)
                                {
                                    if (field[x, y] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        field[x, y - 1] = 0;
                                        field[x, y] = 1;
                                        pictures[x, y] = pictures[x, y - 1];
                                        pictures[x, y - 1] = null;
                                        number[x, y] = number[x, y - 1];
                                        number[x, y - 1] = null;
                                        pictures[x, y].Location = new Point(pictures[x, y].Location.X + 56, pictures[x, y].Location.Y);
                                        if (IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                    else
                                    {
                                        int a = int.Parse(number[x, y].Text);
                                        int b = int.Parse(number[x, y - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            number[x, y].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, x, y);
                                            lb_score.Text = "" + score;
                                            field[x, y - 1] = 0;
                                            this.Controls.Remove(pictures[x, y - 1]);
                                            this.Controls.Remove(number[x, y - 1]);
                                            pictures[x, y - 1] = null;
                                            number[x, y - 1] = null;
                                        }
                                        if (IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Left":
                    for (int x = 0; x < 4; x++)
                    {
                        for (int i = 1; i < 4; i++)
                        {
                            if (field[x, i] == 1)
                            {
                                for (int y = i - 1; y >= 0; y--)
                                {
                                    if (field[x, y] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        field[x, y + 1] = 0;
                                        field[x, y] = 1;
                                        pictures[x, y] = pictures[x, y + 1];
                                        pictures[x, y + 1] = null;
                                        number[x, y] = number[x, y + 1];
                                        number[x, y + 1] = null;
                                        pictures[x, y].Location = new Point(pictures[x, y].Location.X - 56, pictures[x, y].Location.Y);
                                        if (IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                    else
                                    {
                                        int a = int.Parse(number[x, y].Text);
                                        int b = int.Parse(number[x, y + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            number[x, y].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, x, y);
                                            lb_score.Text = "" + score;
                                            field[x, y + 1] = 0;
                                            this.Controls.Remove(pictures[x, y + 1]);
                                            this.Controls.Remove(number[x, y + 1]);
                                            pictures[x, y + 1] = null;
                                            number[x, y + 1] = null;
                                        }
                                        if (IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                    for (int x = 2; x >= 0; x--)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (field[x, i] == 1)
                            {
                                for (int y = x + 1; y < 4; y++)
                                {
                                    if (field[y, i] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        field[y - 1, i] = 0;
                                        field[y, i] = 1;
                                        pictures[y, i] = pictures[y - 1, i];
                                        pictures[y - 1, i] = null;
                                        number[y, i] = number[y - 1, i];
                                        number[y - 1, i] = null;
                                        pictures[y, i].Location = new Point(pictures[y, i].Location.X, pictures[y, i].Location.Y + 56);
                                        if (IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                    else
                                    {
                                        int a = int.Parse(number[y, i].Text);
                                        int b = int.Parse(number[y - 1, i].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            number[y, i].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, y, i);
                                            lb_score.Text = "" + score;
                                            field[y - 1, i] = 0;
                                            this.Controls.Remove(pictures[y - 1, i]);
                                            this.Controls.Remove(number[y - 1, i]);
                                            pictures[y - 1, i] = null;
                                            number[y - 1, i] = null;
                                        }
                                        if(IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up":
                    for (int x = 1; x < 4; x++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (field[x, i] == 1)
                            {
                                for (int y = x - 1; y >= 0; y--)
                                {
                                    if (field[y, i] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        field[y + 1, i] = 0;
                                        field[y, i] = 1;
                                        pictures[y, i] = pictures[y + 1, i];
                                        pictures[y + 1, i] = null;
                                        number[y, i] = number[y + 1, i];
                                        number[y + 1, i] = null;
                                        pictures[y, i].Location = new Point(pictures[y, i].Location.X, pictures[y, i].Location.Y - 56);
                                        if (IsGameLost())
                                        {
                                           HandleGameOver();
                                        }
                                    }
                                    else
                                    {
                                        int a = int.Parse(number[y, i].Text);
                                        int b = int.Parse(number[y + 1, i].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            number[y, i].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, y, i);
                                            lb_score.Text = "" + score;
                                            field[y + 1, i] = 0;
                                            this.Controls.Remove(pictures[y + 1, i]);
                                            this.Controls.Remove(number[y + 1, i]);
                                            pictures[y + 1, i] = null;
                                            number[y + 1, i] = null;
                                        }
                                        if (IsGameLost())
                                        {
                                            HandleGameOver();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            if (ifPicWasMoved)
                CreateNewPicture();
        }

        private void btn_surrender_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Your final score is " + score + ". Your highscore is " + getHighscore(session_username, constring) + "." +
                "Click OK to start again", "Game Ended!", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                this.Hide();
                form_minigame1 form_Minigame1 = new form_minigame1();
                form_Minigame1.ShowDialog();
            }
            else return;
        }
        private bool IsGameLost()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (field[i, j] == 0)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] == field[i, j + 1])
                    {
                        return true;
                    }
                }
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (field[i, j] == field[i + 1, j])
                    {
                        return true;
                    }
                }
            }

            return true;
        }
        private void HandleGameOver()
        {
            int score = Convert.ToInt32(lb_score.Text);
            if (score > Convert.ToInt32(getHighscore(session_username, constring)))
            {
                setHighscore(session_username, score, constring);
            }
            DialogResult dr = MessageBox.Show("You lost! Your final score is " + score + ". Your highscore is " + getHighscore(session_username, constring) + ".", "Game Over!", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                this.Hide();
                form_minigame1 form_Minigame1 = new form_minigame1();
                form_Minigame1.ShowDialog();
            }
        }
    }
}
