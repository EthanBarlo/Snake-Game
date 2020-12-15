using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace SnakeTest
{
    class SnakeGame
    {
        // Attributes
        Panel GamePanel;
        PictureBox snakeHead;
        GameForm gameForm;

        SoundPlayer AppleBiteSound = new SoundPlayer(Properties.Resources.AppleBite);
        SoundPlayer WallHitSound = new SoundPlayer(Properties.Resources.WallHit);
        SoundPlayer SnakeHitSound = new SoundPlayer(Properties.Resources.SnakeHit);
        SoundPlayer GameOverSound = new SoundPlayer(Properties.Resources.GameOver);

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
        public SnakeGame(Panel gamePanel , PictureBox snakeHead, GameForm gameForm)
        {
            this.GamePanel = gamePanel;
            this.snakeHead = snakeHead;
            this.gameForm = gameForm;
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

        //-------------------------------------------------------------------------------------------
        // Game Operations
        //--------------------------------------------
        // Movement
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

        private void MoveHead(int move, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                case Direction.LEFT:
                    SnakeHead.MoveX(move);
                    if (SnakeHead.GetX() < 0 || SnakeHead.GetX() >= GamePanel.Width) WallHit(direction);
                    break;
                case Direction.UP:
                case Direction.DOWN:
                    SnakeHead.MoveY(move);
                    if (SnakeHead.GetY() < 0 || SnakeHead.GetY() >= GamePanel.Height) WallHit(direction);
                    break;
            }
            currentMoveDirection = direction;
            snakeDirectionImage = $"{direction}";
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
                    MoveHead(-GameSettings.CellSize, updateMoveDirection);
                    snakeHead.Image = bmpSnakeHeadRotated[0];
                    break;
                case Direction.DOWN:
                    MoveHead(+GameSettings.CellSize, updateMoveDirection);
                    snakeHead.Image = bmpSnakeHeadRotated[2];
                    break;
                case Direction.LEFT:
                    MoveHead(-GameSettings.CellSize, updateMoveDirection);
                    snakeHead.Image = bmpSnakeHeadRotated[3];
                    break;
                case Direction.RIGHT:
                    MoveHead(+GameSettings.CellSize, updateMoveDirection);
                    snakeHead.Image = bmpSnakeHeadRotated[1];
                    break;
            }
            if (!gameForm.pause)
                HasColission();
        }

        //--------------------------------------------
        // Collision Detection
        private void WallHit(Direction direction)
        {
            if (GameSettings.Teleport)
            {
                switch (direction)
                {
                    case Direction.UP:
                        SnakeHead.MoveSnake(SnakeHead.GetX(), GamePanel.Height - GameSettings.CellSize);
                        break;
                    case Direction.DOWN:
                        SnakeHead.MoveSnake(SnakeHead.GetX(), 0);
                        break;
                    case Direction.LEFT:
                        SnakeHead.MoveSnake(GamePanel.Width - GameSettings.CellSize, SnakeHead.GetY());
                        break;
                    case Direction.RIGHT:
                        SnakeHead.MoveSnake(0, SnakeHead.GetY());
                        break;
                }
            }
            else
            {
                WallHitSound.Play();
                Reset();
                gameForm.gameEnd();
            }
        }
        //----------------
        // Colission Operations
        public void HasColission()
        {
            if (HitApple())
                AppleEaten();
            else if (HitSnakeBody())
            {
                SnakeHitSound.Play();
                Reset();
                gameForm.gameEnd();
            }
        }

        bool HitApple()
        {
            return SnakeHead.GetY() == apple.GetY() && SnakeHead.GetX() == apple.GetX();
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
        //----------------

        //--------------------------------------------

        //----------------
        // Apple Eaten
        public void AppleEaten()
        {
            apple.MoveRandom(SnakeHead);
            AppleBiteSound.Play();
            AddSnakePiece();
            gameForm.IncreaseScore();
        }

        public void AddSnakePiece()
        {
            SnakeBody.Last().Type = "body";
            Snake lastSnake = SnakeBody.Last();
            SnakeBody.Add(new Snake(lastSnake, GamePanel, "tail", lastSnake.Direction));
            snakeLength += 1;
        }
        //----------------

        //-------------------------------------------------------------------------------------------
        // Misc
        public void Reset()
        {
            GameOverSound.Play();

            // Removing all snakes from the gameSpace
            foreach (Snake snake in SnakeBody)
            {
                snake.remove(GamePanel);
            }
            SnakeBody.Clear();


            int center = ((GamePanel.Height / GameSettings.CellSize) / 2) * GameSettings.CellSize;
            SnakeHead.MoveSnake(center, center);

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
