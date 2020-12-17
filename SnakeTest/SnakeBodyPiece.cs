using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class SnakeHead : SnakeBodyPiece
    {
        // Constructor
        public SnakeHead(PictureBox pBox) : base(pBox) { }

        // SnakeHead Operations
        public void MoveY(int y)
        {
            entity.Top += y;
        }
        public void MoveX(int x)
        {
            entity.Left += x;
        }
    }

    class SnakeBodyPiece : Piece
    {
        // Attributes
        public String Type { get; set; }
        public String Direction { get; set; }

        // Constructors
        public SnakeBodyPiece(SnakeBodyPiece previousSnake, Panel panel, string type = "body", string direction = "") : base(panel)
        {
            this.Type = type;
            MoveSnake(previousSnake.GetX(), previousSnake.GetY(), direction);
        }
        public SnakeBodyPiece(PictureBox pBox) : base(pBox) {}


        //-------------------------------------------------------------------------------------------
        // Public Operations
        //----------------------------------------------------
        // Standard Operations
        public void MoveSnake(int x, int y, string direction = "", Image img = null)
        {
            entity.Top = y;
            entity.Left = x;
            this.Direction = direction;
            if (direction != "" && img == null )
                SetDirection(direction);
            else if (Type == "tail")
                SetTailDirection(direction);
            else
                entity.Image = img;
        }

        //----------------------------------------------------
        // Design Operations
        private void SetDirection(string direction)
        {
            switch (direction)
            {
                // Corners
                case "DOWN-LEFT":
                case "RIGHT-UP":
                    entity.Image = Properties.Resources.snakeNorth_West;
                    break;
                case "UP-LEFT":
                case "RIGHT-DOWN":
                    entity.Image = Properties.Resources.snakeSouth_West;
                    break;
                case "UP-RIGHT":
                case "LEFT-DOWN":
                    entity.Image = Properties.Resources.snakeSouth_East;
                    break;
                case "DOWN-RIGHT":
                case "LEFT-UP":
                    entity.Image = Properties.Resources.snakeNorth_East;
                    break;
                // Horizontal/Vertical
                case "UP":
                case "DOWN":
                    entity.Image = Properties.Resources.snakeBodyVertical;
                    break;
                case "LEFT":
                case "RIGHT":
                    entity.Image = Properties.Resources.snakeBodyHorizontal;
                    break;
            }
            this.Direction = direction;
        }

        // For passing the image down, when we know what it is
        public Image GetImage()
        {
            return entity.Image;
        }

        // Only happens when it reaches the tail
        private void SetTailDirection(string direction)
        {
            if (direction.Length > 5)
            {
                string[] splitted = { };
                splitted = direction.Split("-");
                direction = splitted[1];
            }

            switch (direction)
            {
                case "UP":
                    entity.Image = Properties.Resources.snakeTailNorth;
                    break;
                case "DOWN":
                    entity.Image = Properties.Resources.snakeTailSouth;
                    break;
                case "LEFT":
                    entity.Image = Properties.Resources.snakeTailWest;
                    break;
                case "RIGHT":
                    entity.Image = Properties.Resources.snakeTailEast;
                    break;
            }
            this.Direction = direction;
        }
    }
}
