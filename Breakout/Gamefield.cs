using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Gamefield
    {
        public int Width { get; set; }
        public int Height { get; set; }

        private GameObject[] gameObjects;
        private Player Player;
        private Ball Ball;

        public char[,] gameBoard;

        public Gamefield(int width, int height, Ball ball, Player player)
        {
            this.Width = width;
            this.Height = height;

            this.Ball = ball;
            this.Player = player;

            this.gameBoard = new char[height, width];
        }

        public void Update()
        {
            foreach (GameObject gameObject in this.gameObjects)
            {
                if (gameObject is Ball)
                {
                    Ball ball = gameObject as Ball;
                    int nextX = ball.Coordinates.
                }
                else if (gameObject is Player)
                {

                }
            }
        }
    }
}
