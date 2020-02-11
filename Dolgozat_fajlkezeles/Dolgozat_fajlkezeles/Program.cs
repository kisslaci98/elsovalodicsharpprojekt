using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dolgozat_fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[54];
            int szamok_1 = 0;
            int nulla = 0;
            using (StreamReader sr = new StreamReader("szamokfejlecdb.txt", Encoding.UTF8))
            {
                for (int i = 0; i < 54; i++)
                {
                    tomb[i] = Int32.Parse(sr.ReadLine());
                    if (tomb[i] >= 15)
                    {
                        szamok_1++;
                    }
                    if (tomb[i] == 0)
                    {
                        nulla++;
                    }
                }
                Array.Sort(tomb);
            }
            Console.WriteLine($"1.feladat: A 15-öt elérő számok darabszáma: {szamok_1}");
            Console.WriteLine($"\n2.feladat: A számok növekvő sorrendben: ");
            foreach (int i in tomb)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"\n3.feladat: {nulla} db nulla van a számok között.");
            Console.WriteLine($"\n4.feladat: {tomb.Max()} a legnagyobb szám.");

            Console.ReadKey(true);
        }
    }
}
