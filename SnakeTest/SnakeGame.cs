using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeTest
{
    class SnakeGame
    {
        // Attributes
        Panel GamePanel;
        PictureBox snakeHead;

        SnakeHead SnakeHead;
        List<Snake> SnakeBody = new List<Snake>();
        int snakeLength;

        Apple apple;

        Bitmap bmpSnakeHead;
        Image[] bmpSnakeHeadRotated;

        Direction updateMoveDirection;   // User Input Change
        Direction currentMoveDirection;  // Direction Snake is currently moving in
        string snakeDirectionImage;   // So all following SnakeBody pieces know what image to display

        enum Direction { UP, DOWN, LEFT, RIGHT}



        // Constructor
        public SnakeGame(Panel gamePanel , PictureBox snakeHead)
        {
            this.GamePanel = gamePanel;
            this.snakeHead = snakeHead;
            // Initilizing the snake
            SnakeHead = new SnakeHead(snakeHead);
            SnakeBody.Add(new Snake(SnakeHead, GamePanel));
            SnakeBody.Add(new Snake(SnakeHead, GamePanel));
            SnakeBody.Add(new Snake(SnakeHead, GamePanel));
            SnakeBody.Add(new Snake(SnakeHead, GamePanel, "tail"));
            snakeLength = SnakeBody.Count;
            
            apple = new Apple(GamePanel, SnakeHead, SnakeBody);

            // Snake Head Rotation
            bmpSnakeHead = new Bitmap(snakeHead.Image);
            bmpSnakeHeadRotated = rotateImage(bmpSnakeHead);
        }

        // Game Operations
        public void ChangeDirection(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (currentMoveDirection != Direction.DOWN)
                    {
                        updateMoveDirection = Direction.UP;
                    }
                    break;
                case Keys.Down:
                    if (currentMoveDirection != Direction.UP)
                    {
                        updateMoveDirection = Direction.DOWN;
                    }
                    break;
                case Keys.Left:
                    if (currentMoveDirection != Direction.RIGHT)
                    {
                        updateMoveDirection = Direction.LEFT;
                    }
                    break;
                case Keys.Right:
                    if (currentMoveDirection != Direction.LEFT)
                    {
                        updateMoveDirection = Direction.RIGHT;
                    }
                    break;
            }
        }

        public void MoveSnake()
        {
            // Updating the location of each snake piece
            if(currentMoveDirection != updateMoveDirection)
            {
                snakeDirectionImage = $"{currentMoveDirection}-{updateMoveDirection}";
            }
            for (int i = (snakeLength - 1); i >= 0; i--)
            {
                if (i == 0)
                    SnakeBody[i].MoveSnake(SnakeHead.GetX(), SnakeHead.GetY(), snakeDirectionImage);
                else
                    SnakeBody[i].MoveSnake(SnakeBody[i - 1].GetX(), SnakeBody[i - 1].GetY(), SnakeBody[i - 1].Direction, img: SnakeBody[i - 1].GetImage());
            }

            // Moving the SnakeHead
            switch (updateMoveDirection)
            {
                case Direction.UP:
                    SnakeHead.MoveY(-20);
                    if (SnakeHead.GetY() < 0)
                    {
                        SnakeHead.MoveSnake(SnakeHead.GetX(), GamePanel.Height - 20);
                    }
                    currentMoveDirection = Direction.UP;
                    snakeDirectionImage = $"{Direction.UP}";
                    snakeHead.Image = bmpSnakeHeadRotated[0];
                    break;
                case Direction.DOWN:
                    SnakeHead.MoveY(+20);
                    if (SnakeHead.GetY() >= GamePanel.Height)
                    {
                        SnakeHead.MoveSnake(SnakeHead.GetX(), 0);
                    }
                    currentMoveDirection = Direction.DOWN;
                    snakeDirectionImage = $"{Direction.DOWN}";
                    snakeHead.Image = bmpSnakeHeadRotated[2];
                    break;
                case Direction.LEFT:
                    SnakeHead.MoveX(-20);
                    if (SnakeHead.GetX() < 0)
                    {
                        SnakeHead.MoveSnake(GamePanel.Width - 20, SnakeHead.GetY());
                    }
                    currentMoveDirection = Direction.LEFT;
                    snakeDirectionImage = $"{Direction.LEFT}";
                    snakeHead.Image = bmpSnakeHeadRotated[3];
                    break;
                case Direction.RIGHT:
                    SnakeHead.MoveX(+20);
                    if (SnakeHead.GetX() >= GamePanel.Width)
                    {
                        SnakeHead.MoveSnake(0, SnakeHead.GetY());
                    }
                    currentMoveDirection = Direction.RIGHT;
                    snakeDirectionImage = $"{Direction.RIGHT}";
                    snakeHead.Image = bmpSnakeHeadRotated[1];
                    break;
            }
        }

        
        public void AddSnakePiece()
        {
            SnakeBody.Last().Type = "body";
            Snake lastSnake = SnakeBody.Last();
            SnakeBody.Add(new Snake(lastSnake, GamePanel, "tail", lastSnake.Direction));
            snakeLength += 1;
        }

        public string HasColission()
        {
            if (HitApple())
                return "apple";
            else if (HitSnakeBody())
                return "snakeBody";

            return "";
        }

        bool HitSnakeBody()
        {
            foreach (Snake snake in SnakeBody)
            {
                if (SnakeHead.GetY() == snake.GetY() && SnakeHead.GetX() == snake.GetX()) 
                { return true; }
            }
            return false;
        }

        bool HitApple()
        {
            return SnakeHead.GetY() == apple.GetY() && SnakeHead.GetX() == apple.GetX();
        }

        public void AppleEaten()
        {
            apple.MoveRandom(SnakeHead);
            AddSnakePiece();
            // need to increase score
        }

        public void Reset()
        {
            // Removing all snakes from the gameSpace
            foreach (Snake snake in SnakeBody)
            {
                snake.remove(GamePanel);
            }
            SnakeBody.Clear();
            // Creating the starting snake length & moving the apple
            SnakeBody.Add(new Snake(SnakeHead, GamePanel));
            SnakeBody.Add(new Snake(SnakeHead, GamePanel));
            SnakeBody.Add(new Snake(SnakeHead, GamePanel));
            SnakeBody.Add(new Snake(SnakeHead, GamePanel, "tail"));
            snakeLength = SnakeBody.Count;
            apple.MoveRandom(SnakeHead);
        }

        // Design Operations
        private Image[] rotateImage(Bitmap bmp)
        {
            Image[] tmpRotate = new Image[4];
            tmpRotate[0] = new Bitmap(bmp);
            for (int i = 1; i <= 3; i++)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                tmpRotate[i] = new Bitmap(bmp);
            }
            return tmpRotate;
        }
    }
}
