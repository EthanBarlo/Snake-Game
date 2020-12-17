using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Snake
{
    class SnakeGame
    {
        //-------------------------------------------------------------------------------------------
        // Attributes
        //--------------------------------------
        // GameForm
            Panel GamePanel;
            PictureBox snakeHead;
            GameForm gameForm;
        //--------------------------------------
        // Audio
            SoundPlayer AppleBiteSound = new SoundPlayer(Properties.Resources.AppleBite);
            SoundPlayer GameOverSound = new SoundPlayer(Properties.Resources.GameOver);
        //--------------------------------------
        // Snake/Apple Objects
            SnakeHead SnakeHead;
            List<SnakeBodyPiece> SnakeBody = new List<SnakeBodyPiece>();
            Apple apple;
            int snakeLength;
        //--------------------------------------
        // Bitmap for SnakeHead
            Bitmap bmpSnakeHead;
            Image[] bmpSnakeHeadRotated;
        //--------------------------------------
        // Direction
            enum Direction { UP, DOWN, LEFT, RIGHT }
            Direction updateMoveDirection;   // User Input Change
            Direction currentMoveDirection;  // Direction Snake is currently moving in
            string snakeDirectionImage;   // So all following SnakeBody pieces know what image to display


        //-------------------------------------------------------------------------------------------
        // Constructor
        public SnakeGame(Panel gamePanel , PictureBox snakeHead, GameForm gameForm)
        {
            // Storing GameForm attributes
            this.GamePanel = gamePanel;
            this.snakeHead = snakeHead;
            this.gameForm = gameForm;

            // Initilizing the snake
            SnakeHead = new SnakeHead(snakeHead);
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel));
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel));
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel));
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel, "tail"));
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
                default:
                    return;
            }
            if (gameForm.pause == true)
                gameForm.PauseGame();
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
        // Colission Operations
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
                new SoundPlayer(Properties.Resources.WallHit).PlaySync();
                Reset();
                gameForm.GameOver();
            }
        }

        public void HasColission()
        {
            if (HitApple())
                AppleEaten();
            else if (HitSnakeBody())
            {
                // Corupts after being played a few times so we need to make a new SoundPlayer each time
                new SoundPlayer(Properties.Resources.SnakeHit).PlaySync(); 
                Reset();
                gameForm.GameOver();
            }
        }

        private bool HitApple()
        {
            return SnakeHead.GetY() == apple.GetY() && SnakeHead.GetX() == apple.GetX();
        }

        private bool HitSnakeBody()
        {
            foreach (SnakeBodyPiece snake in SnakeBody)
            {
                if (SnakeHead.GetY() == snake.GetY() && SnakeHead.GetX() == snake.GetX()) 
                    return true;
            }
            return false;
        }

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
            SnakeBodyPiece lastSnake = SnakeBody.Last();
            SnakeBody.Add(new SnakeBodyPiece(lastSnake, GamePanel, "tail", lastSnake.Direction));
            snakeLength += 1;
        }

        //-------------------------------------------------------------------------------------------
        // Misc
        public void Reset()
        {
            GameOverSound.Play();

            // Removing all snakes from the gameSpace
            foreach (SnakeBodyPiece snake in SnakeBody)
            {
                snake.Remove(GamePanel);
            }
            SnakeBody.Clear();


            int center = ((GamePanel.Height / GameSettings.CellSize) / 2) * GameSettings.CellSize;
            SnakeHead.MoveSnake(center, center);

            // Creating the starting snake length & moving the apple
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel));
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel));
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel));
            SnakeBody.Add(new SnakeBodyPiece(SnakeHead, GamePanel, "tail"));
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
