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
            int fieldWidth = 50;
            int fieldHeight = 20;
            this.GameField = new Gamefield(fieldWidth, fieldHeight, new Ball(new Point(5, 5), 1),
                new Player(new Point(fieldWidth/2 - 2, fieldHeight - 2), "test"));
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
