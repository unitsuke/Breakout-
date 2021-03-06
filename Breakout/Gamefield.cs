﻿using System;
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
        private List<Block> blocks { get; set; }
        private Player Player { get; set; }
        private Ball Ball { get; set; }

        public string[,] gameBoard;
        
        public int NumBlocks = 20;

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
            };


            
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            Console.SetWindowSize(this.Width, this.Height);
            Console.SetBufferSize(this.Width, this.Height);
            
            //blocks
            int numOfRowOneBlocks = 30;
            for (int b = 0; b < numOfRowOneBlocks; b++)
            {
                GameObjects.Add(new Block(

                    new Point((this.Width - numOfRowOneBlocks) / 2 + b, 1), 1, 100));
            }
            int numOfRowTwoBlocks = 20;
            for (int b = 0; b < numOfRowTwoBlocks; b++)
            {
                GameObjects.Add(new Block(

                    new Point((this.Width - numOfRowTwoBlocks) / 2 + b, 2), 1, 100));
            }

            //print blocks
            foreach (var Block in GameObjects)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(Block.Point.X, Block.Point.Y);
                Console.Write(Block.Symbol);
                Console.ForegroundColor = ConsoleColor.White;
            }
            this.gameBoard = new string[this.Width, this.Height];

            foreach (var gameObj in this.GameObjects)
            {
                int objX = gameObj.Point.X;
                int objY = gameObj.Point.Y;
                // FIXED
                this.gameBoard[objX, objY] = gameObj.Symbol;
            }

            for (int i = 0; i < this.Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(this.Width - 1, i);
                Console.Write("|");
            }
            //print new player
            for (int i = 0; i < Player.LENGHT; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(this.Player.Point.X + i, this.Player.Point.Y);
                Console.Write(Player.Symbol);
            }
            
            
        }

        public void Run()
        {


            while (this.IsAlive)
            {
                Update();
                Thread.Sleep(25);
                if (this.Player.Lifes == 0)
                {
                    IsAlive = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(this.Width/2 - 10 , 5);
                    Console.WriteLine("GAME OVER, YOU ARE DEAD");
                }
                if (this.NumBlocks == 0)
                {
                    IsAlive = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(this.Width / 2 - 10, 5);
                    Console.WriteLine("GAME OVER, YOU WON");

                }
            }
        }
        public void Update()
        {
            int numberOfBlocks = 20;

            foreach (GameObject gameObject in this.GameObjects)
            {
                if (gameObject is Ball)
                {
                    Thread.Sleep(15);
                    
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
                            numberOfBlocks--;
                            break;
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
                    //hits top
                    if (nextY == -1 )
                    {
                        this.Ball.Direction.Y *= -1;
                        nextY = this.Ball.Point.Y + this.Ball.Direction.Y;
                    }
                    //hits bottom
                    if(nextY > this.Height - 1)
                    {
                        this.Ball.Direction.Y *= -1;
                        nextY = this.Ball.Point.Y + this.Ball.Direction.Y;
                        this.Player.Lifes--;
                    }

                    //Delete the previous ball position and draw the new one
                    //fixed : if not on the most right
                    if (this.Ball.Point.X != this.Width - 1)
                    {
                        Console.SetCursorPosition(this.Ball.Point.X, this.Ball.Point.Y);
                        Console.Write(" ");
                    }

                    
                    this.Ball.Point.X = nextX;
                    this.Ball.Point.Y = nextY;

                    if (this.Ball.Point.X != this.Width - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(this.Ball.Point.X, this.Ball.Point.Y);
                        Console.Write(this.Ball.Symbol);
                    }

                }
                else if (gameObject is Player)
                {
                    //moving player

                    if (Console.KeyAvailable)
                    {
                        //remove old player
                        for (int i = 0; i < Player.LENGHT; i++)
                        {
                            Console.SetCursorPosition(this.Player.Point.X + i, this.Player.Point.Y);
                            Console.Write(" ");
                        }
                        
                        //move player cordinates
                        ConsoleKeyInfo userInput = Console.ReadKey();
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            
                            this.Player.Point.X--;
                            if (this.Player.Point.X<1)
                            {
                                this.Player.Point.X = 1;
                            }
                            
                        }
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            this.Player.Point.X++;
                            if (this.Player.Point.X > Width-5)
                            {
                                this.Player.Point.X = Width-5;
                            }
                        }
                        //print new player
                        for (int i = 0; i < Player.LENGHT; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(this.Player.Point.X + i, this.Player.Point.Y);
                            Console.Write(Player.Symbol);
                        }
                    }
                    else if (gameObject is Block)
                    {
                        
                        Console.SetCursorPosition(gameObject.Point.X, gameObject.Point.Y);
                        Console.Write(Block.SYMBOL);

                    }

                }
            }
        }
    }
}
