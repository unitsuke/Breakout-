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

        public Player(string name)
        {
            this.username = name;
            this.symbol = "====";
            this.lifes = 3;
        }
    }
}
