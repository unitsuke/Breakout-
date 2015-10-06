using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout
{
    public class Engine
    {
        public Gamefield GameField { get; set; }

        public Engine()
        {
            this.GameField = new Gamefield(55, 20, new Ball(new Point(5, 5), 1), new Player(new Point(5, 5), "test"));
        }

        /// <summary>
        /// Where the game starts
        /// </summary>
        public void Start()
        {
            this.GameField.Run();
        }
    }
}
