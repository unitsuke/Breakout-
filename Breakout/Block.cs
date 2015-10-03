using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Block
    {
        static char charBlock = '#';
        //properties
        public Point BlockPoint { get; set; }
        public int Life { get; set; }
        public int Score { get; set; }

        //constructor
        public Block(Point point,int life, int score)
        {
            this.BlockPoint = point;
            this.Life = life;
            this.Score = score;
        }
    }
}
