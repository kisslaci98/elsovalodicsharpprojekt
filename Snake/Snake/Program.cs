using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} és {magassag}");

            int x = szelesseg / 2;
            int y = magassag / 2;

            int[] xKoord = new int[5];
            int[] yKoord = new int[5];

            for (int i = 0; i < 5; i++)
            {
                xKoord[i] = x + i;
                yKoord[i] = y;
                Console.SetCursorPosition(xKoord[i], yKoord[i]);
                Console.Write("*");
            }

            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (cki.Key != ConsoleKey.Escape)
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    
                    case ConsoleKey.LeftArrow:
                        x = x - 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        Felfele(ref xKoord, ref yKoord);
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        break;
                    case ConsoleKey.RightArrow:
                        x = x + 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        break;
                    case ConsoleKey.DownArrow:
                        y = y + 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        break;
                }
            }

            //Console.ReadKey(true);
        }

        static void Megrajzol(int[] x, int[] y)
        {
            for (int i = 0; i < 5; i++)
            {
                x[i] = a + i;
                y[i] = b;
                Console.SetCursorPosition(x[i], y[i]);
                Console.Write("*");
            }
        }

        static void Felfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 5; i++)
            {
                x[i] = atmenetX[i - 1];
                x[i] = atmenetY[i - 1];
            }
            x[0] = atmenetX[0];
            y[0] = atmenetY[0] - 1;
        }
    }
}
