using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mivel számoljak? (kör, négyzet, téglalap, derékszögű háromszög)");
            string input = Console.ReadLine();
            if (input == "kör")
            {
                Console.Clear();
                Console.Write("Adja meg a kör sugarát:");
                double radius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A sugár: " + radius);
                double circumference = 2 * radius * Math.PI;
                Console.WriteLine("A kerület: " + circumference);
                double territory = radius * radius * Math.PI;
                Console.WriteLine("A terület: " + territory);
                Console.ReadKey(true);

            }
            else if (input == "négyzet")
            {
                Console.Clear();
                Console.Write("Adja meg a négyzet oldalát: ");
                int side = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A kerület: " + (4 * side));
                Console.WriteLine("A terület: " + (side * side));
                Console.ReadKey(true);
            }
            else if (input == "téglalap")
            {
                Console.Clear();
                Console.Write("Kérem a téglalap egyik oldalhosszát: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem a téglalap másik oldalhosszát: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A téglalap kerülete: " + (a + b) * 2);
                Console.WriteLine("A téglalap területe: " + (a * b));
                Console.ReadKey(true);
            }
            else if (input == "derékszögű háromszög")
            {
                Console.Clear();
                Console.Write("Kérem a derékszögű háromszög egyik befogóját: ");
                double c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kérem a derékszögű háromszög másik befogóját: ");
                double d = Convert.ToInt32(Console.ReadLine());
                double e = Math.Sqrt((c * c) + (d * d));
                double circumference = (c + d + e);
                double territory = (c * d) / 2;
                Console.WriteLine("A háromszög kerülete: " + circumference);
                Console.WriteLine("A háromszög területe: " + territory);
                Console.ReadKey(true);

            }
            else
            {
                Console.WriteLine("Nem megfelelő bemenet!");
                Console.ReadKey(true);
            }
            }
    }
}
