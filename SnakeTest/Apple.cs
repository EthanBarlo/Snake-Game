using System.Windows.Forms;
using System;

namespace SnakeTest
{
    class Apple : Piece
    {
        // Attributes
        Random rand = new Random();
        Panel gameBoard;

        // Constructor
        public Apple(Panel panel) : base(panel)
        {
            //entity.BackColor = System.Drawing.Color.DarkRed;
            entity.Image = Properties.Resources.apple;
            gameBoard = panel;
            MoveRandom();
        }

        // Operations
        public void MoveRandom()
        {
            entity.Top = rand.Next(gameBoard.Height / 20) * 20;
            entity.Left = rand.Next(gameBoard.Width / 20) * 20;
        }
    }
}
