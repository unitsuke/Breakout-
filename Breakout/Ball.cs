using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Ball : GameObject
    {
        public static const char SYMBOL = '@';

        static Point[] direction = { new Point(1,0) };

        //properties
        public Point BallPoint { get ; set; }
        public Point Direction { get; set; }
        public int Damage { get; set; }

        
        //constructor
        public Ball(Point point, int damage)
        {
            this.BallPoint = point;
            this.Damage = damage;
        }
    }
}
