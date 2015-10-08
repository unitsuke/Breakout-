using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class Menu
    {
        public int option;

        public void Start()
        {
            option = 0;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(50, 10);
            Console.Write("START NEW GAME");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 12);
            Console.Write("TOP 5");
            Console.SetCursorPosition(50, 14);
            Console.Write("CONTROLS");
            Console.SetCursorPosition(50, 16);
            Console.Write("EXIT");

            var key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    option++;
                    if (option == 4)
                    {
                        option = 0;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    option--;
                    if (option == -1)
                    {
                        option = 3;
                    }
                }
                PrintMenu(option);
                key = Console.ReadKey();
            }

            if (option == 0)
            {
                Console.Clear();
                Engine engine = new Engine();
                engine.Start();
            }
            else if (option == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 10);
                Console.Write("1. -----");
                Console.SetCursorPosition(50, 11);
                Console.Write("2. -----");
                Console.SetCursorPosition(50, 12);
                Console.Write("3. -----");
                Console.SetCursorPosition(50, 13);
                Console.Write("4. -----");
                Console.SetCursorPosition(50, 14);
                Console.Write("5. -----");
                Console.ReadLine();
                Console.Clear();
                Menu menu = new Menu();
                menu.Start();
            }
            else if (option == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 10);
                Console.Write("CONTROLS:");
                Console.SetCursorPosition(50, 11);
                Console.Write("LEFT ARROW:");
                Console.SetCursorPosition(50, 12);
                Console.Write("RIGHT ARROW:");
                Console.ReadLine();
                Console.Clear();
                Menu menu = new Menu();
                menu.Start();

            }
            else if (option == 3)
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
        static void PrintMenu(int coloredOption)
        {
            if (coloredOption == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 10);
                Console.Write("START NEW GAME");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 12);
                Console.Write("TOP 5");
                Console.SetCursorPosition(50, 14);
                Console.Write("CONTROLS");
                Console.SetCursorPosition(50, 16);
                Console.Write("EXIT");
            }
            else if (coloredOption == 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 10);
                Console.Write("START NEW GAME");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 12);
                Console.Write("TOP 5");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 14);
                Console.Write("CONTROLS");
                Console.SetCursorPosition(50, 16);
                Console.Write("EXIT");
            }
            else if (coloredOption == 2)
            {
                Console.SetCursorPosition(50, 10);
                Console.Write("START NEW GAME");
                Console.SetCursorPosition(50, 12);
                Console.Write("TOP 5");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 14);
                Console.Write("CONTROLS");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 16);
                Console.Write("EXIT");
            }
            else if (coloredOption == 3)
            {
                Console.SetCursorPosition(50, 10);
                Console.Write("START NEW GAME");
                Console.SetCursorPosition(50, 12);
                Console.Write("TOP 5");
                Console.SetCursorPosition(50, 14);
                Console.Write("CONTROLS");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 16);
                Console.Write("EXIT");

            }
        }
    }
}

