using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public abstract class GameObject
    {
        public Point Coordinates { get; set; }

        public virtual void Move()
        {

        }
    }
}