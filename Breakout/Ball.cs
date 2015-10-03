using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Ball
    {
        static char charBall = '@';
        
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
