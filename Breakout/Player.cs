using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Player
    {
        public string username { get; set; }
        public string sumbol { get; set; }
        public int lifes { get; set; }
        public int moves { get; set; }
        public Point point { get; set; }

        public Player(string name)
        {
            this.username = name;
            this.sumbol = "====";
            this.lifes = 3;
        }
    }
}
