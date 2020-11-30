using System;
using System.Windows.Forms;

namespace SnakeTest
{
    class Snake : Piece
    {
        private String type;
        private String direction = "";

        public Snake(Snake previousSnake, Panel panel, string type = "body", string direction = "") : base(panel)
        {
            this.type = type;
            moveSnake(previousSnake.GetX(), previousSnake.GetY(), direction);
        }

        // Dont really need to create a SnakeHead, doesnt give us any more functionality than before
        public Snake(Label label, string type = "body") : base(label)
        {
            this.type = type;
        }

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
        public int GetX()
        {
            return entity.Location.X;
        }
        public int GetY()
        {
            return entity.Location.Y;
        }


        // For snake design, Using the correct images

        // Not a huge fan of these GetSet, its probably more complicated to use them in this situation
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
                case "downleft":
                case "rightup":
                    entity.Image = Properties.Resources.snakeNorth_West;
                    break;
                case "upleft":
                case "rightdown":
                    entity.Image = Properties.Resources.snakeSouth_West;
                    break;
                case "upright":
                case "leftdown":
                    entity.Image = Properties.Resources.snakeSouth_East;
                    break;
                case "downright":
                case "leftup":
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
                if (direction[0] == 'd')
                    splitted = direction.Split("n");
                else if (direction[0] == 'u')
                    splitted = direction.Split("p");
                else
                    splitted = direction.Split("t");
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
