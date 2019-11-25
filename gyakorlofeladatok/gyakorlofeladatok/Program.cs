using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlofeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Kérem a tömb elemszámát: ");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];
            for (int i = 1; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. számot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());

            }

            int maxKulonbseg = Int32.MinValue;

            for (int i = 0; i < tomb.Length - 1; i++)
            {
                //int kulonbseg = Math.Abs(tomb[i] - tomb[i + 1]);
                int kulonbseg = tomb[i] - tomb[i + 1];
                if (maxKulonbseg <= kulonbseg)
                {
                    maxKulonbseg = kulonbseg;
                }
            }
            Console.WriteLine($"A maximális különbség: {maxKulonbseg}");

            Console.ReadKey(true);
        }
    }
}
