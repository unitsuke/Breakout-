using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Player : GameObject
    {

        public string username { get; set; }
        public string symbol { get; set; }
        public int lifes { get; set; }
        public int moves { get; set; }
        public Point point { get; set; }

        private const string SYMBOL = "=";
        public const int LENGHT = 4;


        public string Username { get; set; }
        public int Lifes { get; set; }
        public int Moves { get; set; }

        public Player(Point point, string name) : base(point, SYMBOL)
        {

            this.username = name;
            this.symbol = "====";
            this.lifes = 3;

            this.Username = name;
            this.Lifes = 3;

        }
    }
}
