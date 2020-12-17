using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace SnakeTest
{
    class Apple : Piece
    {
        // Attributes
        Panel gameBoard;
        List<SnakeBodyPiece> snakeBody;

        // Constructor
        public Apple(Panel panel, SnakeHead snakeHead, List<SnakeBodyPiece> snakeBody) : base(panel)
        {
            entity.Image = Properties.Resources.Apple;
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
                int CellSize = GameSettings.CellSize;

                // Generate random location
                int row = rand.Next(gameBoard.Height / CellSize) * CellSize;
                int col = rand.Next(gameBoard.Width / CellSize) * CellSize;

                // If apple is in same location as SnakeHead, try another
                if (snakeHead.GetX() == col && snakeHead.GetY() == row)
                    continue;


                foreach (var snakePiece in snakeBody)
                {
                    // If apple is in same location as the snakePiece
                    if (row == snakePiece.GetY() && col == snakePiece.GetX())
                    {
                        spaceTaken = true;
                        break; //Break out of foreach
                    }
                }
                // If Space is taken, try another location
                if (spaceTaken)
                    continue;

                // If here, space is empty
                entity.Top = row;
                entity.Left = col;
                break;
            }
        }
    }
}
