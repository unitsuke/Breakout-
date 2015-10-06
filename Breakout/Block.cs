using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Block : GameObject
    {
<<<<<<< HEAD
        public const char SYMBOL = '#';
=======
        private const string SYMBOL = "#";
>>>>>>> origin/master

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
