using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeTest
{
    class Snake : Piece
    {
        // Attributes
        private String type;
        private String direction = "";

        // Constructors
        public Snake(Snake previousSnake, Panel panel, string type = "body", string direction = "") : base(panel)
        {
            this.type = type;
            MoveSnake(previousSnake.GetX(), previousSnake.GetY(), direction);
        }
        public Snake(PictureBox pBox) : base(pBox) {}


        // Game Operations
        // Move SnakeBody
        public void MoveSnake(int x, int y, string direction = "", Image img = null)
        {
            entity.Top = y;
            entity.Left = x;
            this.direction = direction;
            if (direction != "" && img == null )
                SetDirection(direction);
            else if (type == "tail")
                SetTailDirection(direction);
            else
                entity.Image = img;
        }

        // Design Operations
        public String Type   // property
        {
            get { return type; }   // get method
            set { type = value; } // set method
        }
        public String Direction   // property
        {
            get { return direction; }   // get method
            set {direction = value; } // set method
        }

        public Image GetImage()
        {
            return entity.Image;
        }

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
            this.direction = direction;
        }

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
            this.direction = direction;
        }
    }

    class SnakeHead : Snake
    {
        public SnakeHead(PictureBox pBox) : base(pBox){}
        public void MoveY(int y)
        {
            entity.Top += y;
        }
        public void MoveX(int x)
        {
            entity.Left += x;
        }
    }
}
