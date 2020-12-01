using System;
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
            moveSnake(previousSnake.GetX(), previousSnake.GetY(), direction);
        }

        public Snake(Label label, string type = "body") : base(label)
        {
            this.type = type;
        }


        // Game Operations
        public void moveSnake(int x, int y, string direction)
        {
            entity.Top = y;
            entity.Left = x;
            if (direction != "")
                SetDirection(direction); 
        }
        public void moveSnake(int x, int y)
        {
            entity.Top = y;
            entity.Left = x;
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

        private void SetDirection(string direction)
        {
            if (type == "tail")
            {
                SetTailDirection(direction);
                return;
            }
            else if (type == "head")
            {
                return;
            }

            switch (direction)
            {
                // Corners
                case "down-left":
                case "right-up":
                    entity.Image = Properties.Resources.snakeNorth_West;
                    break;
                case "up-left":
                case "right-down":
                    entity.Image = Properties.Resources.snakeSouth_West;
                    break;
                case "up-right":
                case "left-down":
                    entity.Image = Properties.Resources.snakeSouth_East;
                    break;
                case "down-right":
                case "left-up":
                    entity.Image = Properties.Resources.snakeNorth_East;
                    break;
                // Horizontal/Vertical
                case "up":
                case "down":
                    entity.Image = Properties.Resources.snakeBodyVertical;
                    break;
                case "left":
                case "right":
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
                case "up":
                    entity.Image = Properties.Resources.snakeTailNorth;
                    break;
                case "down":
                    entity.Image = Properties.Resources.snakeTailSouth;
                    break;
                case "left":
                    entity.Image = Properties.Resources.snakeTailWest;
                    break;
                case "right":
                    entity.Image = Properties.Resources.snakeTailEast;
                    break;
            }
            this.direction = direction;
        }
    }
}
