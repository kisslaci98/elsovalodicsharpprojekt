using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.feladat
            /*Console.Write("Kérek egy pozitív egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{szam} kettes osztóinak száma: {kettoOszto(szam)}");

            Console.ReadKey(true);*/

            //4.feladat
            /*Console.Write("Kérek egy összeget: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = ermekSzama(szam);

            Console.WriteLine($"A(z) {szam} tartalmaz: ");
            Console.WriteLine($"{tomb[0]}db 200-as érmét.");
            Console.WriteLine($"{tomb[1]}db 100-as érmét.");
            Console.WriteLine($"{tomb[2]}db 50-es érmét.");
            Console.WriteLine($"{tomb[3]}db 20-as érmét.");
            Console.WriteLine($"{tomb[4]}db 10-es érmét.");
            Console.WriteLine($"{tomb[5]}db 5-ös érmét.");
            Console.WriteLine($"{tomb[6]}db 2-es érmét.");
            Console.WriteLine($"{tomb[7]}db 1-es érmét.");
            Console.ReadKey(true);*/

            //5.feladat


            //6.feladat
            Console.Write("Kérek egy összeget: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = szamokSzama;

        }
        static int kettoOszto(int szam)
        {
            int osztokSzama = 0;

            while (szam % 2 == 0)
            {
                osztokSzama++;
                szam /= 2; //szam = szam / 2;
            }

            return osztokSzama;
        }

        static int[] szamokSzama(int szam)
        {
            int meddig = (int)Math.Floor(Math.Log(szam) / Math.Log(2);
            int[] szamokSzama = new int[meddig];
            int[] szamok = new int[] {meddig};
            for (int i = 0; i < szamok.Length; i++)
            {
                while (szam >= szamok[i])
                {
                    szamokSzama[i]++;
                    szam -= szamok[i]; //szam = szam / oszto;
                }
            }
            return szamokSzama;
        }
    }
}
