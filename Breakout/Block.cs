using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Block : GameObject
    {
        public const string SYMBOL = "#";

        //properties
        public int Life { get; set; }
        public int Score { get; set; }

        //constructor
        public Block(Point point, int life, int score)
            : base(point, SYMBOL)
        {
            this.Life = life;
            this.Score = score;
        }
    }
}
