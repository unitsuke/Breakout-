using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Ball
    {
        static char charBall = '@';
        static Random rnd = new Random();
        int randDirection = rnd.Next(0, 4); // returns 0, 1 ,2 or 3
        static Point[] direction =  { 
                                       new Point(-1,-1),//up and left
                                       new Point(1,-1), //up and right
                                       new Point(-1,1), //down and left
                                       new Point(1,1) //down and right
                                    } ;

        //properties
        public Point BallPoint { get ; set; }
        public Point Direction { get; set; }
        public int Damage { get; set; }

        
        //constructor
        public Ball(Point point, int damage)
        {
            this.BallPoint = point;
            this.Damage = damage;
            this.Direction = direction[randDirection]; //random direction
        }
        

    }
}
