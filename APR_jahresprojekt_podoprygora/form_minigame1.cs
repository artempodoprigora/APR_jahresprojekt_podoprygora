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
            InitializeChessBoard();
        }

        private void form_minigame1_Load(object sender, EventArgs e)
        {
            highscore(session_username, lb_highscore, constring);
        }
        private Button[,] chessBoard;

        private void InitializeChessBoard()
        {
            chessBoard = new Button[8, 8];
            var panel = new TableLayoutPanel
            {
                RowCount = 8,
                ColumnCount = 8,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            for (int i = 0; i < 8; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5f));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
            }

            bool isWhite = true;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var square = new Button
                    {
                        Dock = DockStyle.Fill,
                        BackColor = isWhite ? Color.White : Color.Gray,
                        Tag = new Point(row, col)
                    };
                    square.Click += Square_Click;
                    chessBoard[row, col] = square;
                    panel.Controls.Add(square, col, row);
                    isWhite = !isWhite;
                }
                isWhite = !isWhite;
            }

            this.Controls.Add(panel);
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Button clickedSquare = sender as Button;
            Point position = (Point)clickedSquare.Tag;
            MessageBox.Show($"Square clicked at position: {position.X}, {position.Y}");
        }
    }
}
