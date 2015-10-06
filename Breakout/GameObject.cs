using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public abstract class GameObject
    {
        public Point Point { get; set; }
        public string Symbol { get; set; }

        public GameObject(Point point, string Symbol)
        {
            this.Point = point;
            this.Symbol = Symbol;
        }

        public virtual void Move()
        {

        }
    }
}