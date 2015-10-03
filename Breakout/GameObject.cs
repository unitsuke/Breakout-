using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public abstract class GameObject
    {
        public Point Point { get; set; }

        public virtual void Move()
        {

        }
    }
}