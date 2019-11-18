using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refandout
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Kérem az első számot: ");
            int elso = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int masodik = Int32.Parse(Console.ReadLine());
            Console.Write("Kérek egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"A két szám összege: {Osszead(out elso, out masodik, out nev)}");
            Console.WriteLine($"A két szám: {elso}, {masodik}");
            Console.WriteLine($"A név: {nev}");
            Console.Write("Nyomj egy billentyűt a kilépéshez.");

            Console.ReadKey(true);*/

            int szam = -89;
            bool egeszSzam = true;

            do
            {
                Console.Write("Kérek egy egész számot: ");
                egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
            } while (!egeszSzam);

            Console.Write($"A bekért szám: {szam}");

            Console.ReadKey(true);

        }
        /*static int Osszead(int a, int b)
        {
            
            //Létrehozom a visszatérő értéket és inicializálom.
            int osszeg = 0;

            //Kiszámolom a visszatérő értéket.
            osszeg = a + b;

            //Visszaadom a visszatérő értéket.
            return osszeg;
            

            int osszeg = a + b;
            a = 128;
            b = -49;

            return osszeg;

        }*/

        /*static int Osszead(out int a, out int b, out string nev2)
        {
            a = 0;
            b = 0;
            nev2 = "Gábor";
            int osszeg = a + b;
           
            return osszeg;
        }*/

       
    }
}
