using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismetles
{
    enum Napok { Hétfő, Kedd, Szerda, Csütörtök, Péntek, Szombat, Vasárnap }
    class Program
    {
        enum Honap { Január, Február, Március, Április, Május, Június, Július, Augusztus, Szeptember, Október, November, December }
        static void Main(string[] args)
        {
            /* int szam = 2;
             bool kiertekel = true;

             while (kiertekel && szam >= 0)
             {
                 Console.Write("Kérek egy pozitív egész számot: ");
                 kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                 if (szam <= 0)
                 {
                     kiertekel = true;
                     szam = (-1) * szam;
                 }
             }

             Console.WriteLine($"A bekért szám: {szam}");


             Console.ReadKey(true);*/

            //bekérni 2 számot addig, amíg az összegük 10-nél nem lesz kisebb
            /*int a = 1;
            int b = 2;
            bool kiertekel = true;
            bool masikKiertekel = true;

            while ((kiertekel || masikKiertekel) && (a + b) <= 10)
            {
                Console.Write("Kérek egy egész számot: ");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out (a));
                Console.Write("Kérek egy másik egész számot: ");
                masikKiertekel = !Int32.TryParse(Console.ReadLine(), out (b));
                if ((a + b) > 10)
                {
                    kiertekel = true;
                    masikKiertekel = true;
                    a = 1;
                    b = 2;
                }
            }
            Console.Write($"A bekért számok összege: {a + b}");
            Console.ReadKey(true);*/

            //Addig pozitív egész számokat kér be, amíg összegük kisebb, mint 100.

            /*int osszeg = 0;
            int dbszam = 0;
            int szam = 0;

            while (osszeg < 100)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                dbszam++;
            }
            Console.WriteLine($"A számok darabszáma: {--dbszam}, összegük: {osszeg - szam}");
            Console.ReadKey(true);*/

            //Stringeket bekérni, amíg a stringek száma 40 nem lesz, aztán kiíratni az összeset.
            /*string kimenet = "";
            int stringOsszHossz = 0;
            int darabszam = 0;

            while (stringOsszHossz <= 40 )
            {
                Console.Write("Kérek egy stringet: ");
                string beker = Console.ReadLine();
                int hossz = beker.Length;
                if (stringOsszHossz + hossz <= 40)
                {
                    stringOsszHossz += hossz;
                    kimenet += beker;
                    darabszam++;
                }
                else { break; }

            }
            Console.WriteLine($"A bekért stringek száma: {darabszam}");
            Console.WriteLine($"A végső szó: {kimenet}");

            Console.ReadKey(true);*/

            //user által bekért szám faktoriális szorzata
            /*Console.Write("Kérek egy pozitív egész számot 20-ig: ");
            double szam = Convert.ToDouble(Console.ReadLine());

            double fakt = 1;
            double index = 1;

            do
            {
                fakt *= index;
                index++;
            } while (index <= szam);

            Console.WriteLine($"{szam}! = {fakt}");

            Console.ReadKey(true);*/

            //binomiális együttható (n=5) megoldása

            /*for (int k = 1; k < 7; k++)
            {
                Console.SetCursorPosition(k * 7, 0);
                Console.Write($"k = {k - 1}");
                
            }
            for (int n = 1; n < 7; n++)
            {
                Console.SetCursorPosition(0, n);
                Console.Write($"n = {n - 1}");

            }
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.SetCursorPosition(j * 7, i);
                    int fakt = FaktorialisSzamitas(i - 1) / (FaktorialisSzamitas(j - 1) * FaktorialisSzamitas(i - j));
                    Console.Write(fakt);
                }

            }

            Console.ReadKey(true);*/

            Console.Write("Kérek 1-től 10-ig egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            switch (szam)
            {
                case 1:
                    Console.WriteLine("Páratlan szám");
                    break;
                case 2:
                    Console.WriteLine("Páros szám");
                    break;
                case 3:
                    Console.WriteLine("Páratlan szám");
                    break;
                case 4:
                    Console.WriteLine("Páros szám");
                    break;
                case 5:
                    Console.WriteLine("Páratlan szám");
                    break;
                case 6:
                    Console.WriteLine("Páros szám");
                    break;
                case 7:
                    Console.WriteLine("Páratlan szám");
                    break;
                case 8:
                    Console.WriteLine("Páros szám");
                    break;
                case 9:
                    Console.WriteLine("Páratlan szám");
                    break;
                case 10:
                    Console.WriteLine("Páros szám");
                    break;
            }
            Console.ReadKey(true);

        }
        static int FaktorialisSzamitas(int szam)
        {
            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;
            } while (index <= szam);

            return faktorialis;
        }
    }
}
