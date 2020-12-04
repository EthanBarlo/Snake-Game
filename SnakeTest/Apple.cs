using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace SnakeTest
{
    class Apple : Piece
    {
        // Attributes
        Panel gameBoard;
        List<Snake> snakeBody;

        // Constructor
        public Apple(Panel panel, SnakeHead snakeHead, List<Snake> snakeBody) : base(panel)
        {
            //entity.BackColor = System.Drawing.Color.DarkRed;
            entity.Image = Properties.Resources.apple;
            gameBoard = panel;
            this.snakeBody = snakeBody;
            MoveRandom(snakeHead);
        }

        // Operations
        public void MoveRandom(SnakeHead snakeHead)
        {
            bool spaceTaken;
            Random rand = new Random();

            while (true)
            {
                spaceTaken = false;

                // Generate random location
                int row = rand.Next(gameBoard.Height / 20) * 20;
                int col = rand.Next(gameBoard.Width / 20) * 20;

                // If apple is in same location as SnakeHead try another location
                if (snakeHead.GetX() == col && snakeHead.GetY() == row)
                    continue;


                foreach (var snakePiece in snakeBody)
                {
                    // If apple is in same location as the snakePiece check next snakePiece
                    if (row == snakePiece.GetY() && col == snakePiece.GetX())
                    {
                        spaceTaken = true;
                        break; //Break out of foreach
                    }
                }
                // If Space is taken, try another location
                if (spaceTaken)
                    continue;

                // If it made it here, Apple is not in the same location as any SnakePiece
                // And so can be moved
                entity.Top = row;
                entity.Left = col;
                break;
            }
        }
    }
}
