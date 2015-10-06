using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Breakout
{
    public class Gamefield
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsAlive { get; set; }

        private List<GameObject> GameObjects { get; set; }
        private Player Player { get; set; }
        private Ball Ball { get; set; }

        public string[,] gameBoard;

        public Gamefield(int width, int height, Ball ball, Player player)
        {
            this.Width = width;
            this.Height = height;
            this.Ball = ball;
            this.Player = player;
            this.IsAlive = true;

            this.GameObjects = new List<GameObject>()
            {
                this.Player,
                this.Ball,
                new Block(new Point(1,1), 1, 10),
            };

            InitializeBoard();
        }
        private void InitializeBoard()
        {
            
            this.gameBoard = new string[this.Height, this.Width];

            foreach (var gameObj in this.GameObjects)
            {
                int objX = gameObj.Point.X;
                int objY = gameObj.Point.Y;

                this.gameBoard[objX, objY] = gameObj.Symbol;
            }

            for (int i = 0; i < this.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(this.Width - 1, i);
                Console.Write("|");
            }
        }

        public void Run()
        {
            while (this.IsAlive)
            {
                Update();
                Thread.Sleep(25);
            }
        }

        public void Update()
        {
            foreach (GameObject gameObject in this.GameObjects)
            {
                if (gameObject is Ball)
                {
                    int nextX = this.Ball.Point.X + this.Ball.Direction.X;
                    int nextY = this.Ball.Point.Y + this.Ball.Direction.Y;

                    string nextPosChar = " ";

                    // If the next coords are outside of the bounds continue
                    // in the code below they will be fixed
                    try
                    {
                        nextPosChar = gameBoard[nextX, nextY];
                    }
                    catch (IndexOutOfRangeException) { }

                    switch (nextPosChar)
                    {
                        case "#":
                        case "=":

                            this.Ball.Direction.Y *= -1;
                            break;
                        default:
                            break;
                    }

                    if (nextX == 0 || nextX > this.Width - 1)
                    {
                        this.Ball.Direction.X *= -1;
                        nextX = Ball.Point.X + this.Ball.Direction.X;
                    } 

                    if (nextY == -1 || nextY > this.Height - 1)
                    {
                        this.Ball.Direction.Y *= -1;
                        nextY = this.Ball.Point.Y + this.Ball.Direction.Y;
                    }

                    //Delete the previous ball position and draw the new one
                    //fixed : if not on the most right
                    //TO BE FIXED : Blinking wall on the right
                    if (this.Ball.Point.X != this.Width )
                    {
                        Console.SetCursorPosition(this.Ball.Point.X, this.Ball.Point.Y);
                        Console.Write(" ");
                    }

                    this.Ball.Point.X = nextX;
                    this.Ball.Point.Y = nextY;

                    if (this.Ball.Point.X != this.Width)
                    {
                        Console.SetCursorPosition(this.Ball.Point.X, this.Ball.Point.Y);
                        Console.Write(this.Ball.Symbol);
                    }
                    
                    

                }
                else if (gameObject is Player)
                {

                }
            }
        }
    }
}
