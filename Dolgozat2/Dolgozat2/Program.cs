using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Hány szavas legyen a mondat? ");
            int hossz = Int32.Parse(Console.ReadLine());
            string[] mondat = new string[hossz];

            for (int i = 0; i < hossz; i++)
            {
                Console.Clear();
                int szohossz = rnd.Next(1, 12);
                string Szo = "";
                while (Szo.Length != szohossz)
                {
                    Console.Write($"Adj meg egy {szohossz} hosszúságú szót: ");
                    Szo = Console.ReadLine();
                }
                mondat[i] = Convert.ToString(Szo);
            }

            Console.WriteLine("\nA teljes mondat:");
            for (int i = 0; i < mondat.Length; i++)
            {
                if (i == mondat.Length - 1)
                {
                    Console.Write($"{ mondat[i]}.");
                }
                else
                {
                    Console.Write($"{mondat[i]} ");
                }
            }

            Console.ReadKey(true);
        }
    }
}
