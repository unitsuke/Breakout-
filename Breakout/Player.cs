using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Player : GameObject
    {
        private const string SYMBOL = "=";

        public string Username { get; set; }
        public int Lifes { get; set; }
        public int Moves { get; set; }

        public Player(Point point, string name) : base(point, SYMBOL)
        {
            this.Username = name;
            this.Lifes = 3;
        }
    }
}
