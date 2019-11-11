using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/

            //15.feladat
            /*Console.Write("Kérem a pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());
            string kiiratas = "";
            for (int i = 0; i <= bemenoszam; i++)
            {
                kiiratas += i + " ";
            }
            Console.WriteLine(kiiratas);

            Console.ReadKey(true);*/

            //15.feladat (Előltesztelős ciklus)
            /*Console.Write("Kérem a pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());

            int i = 1;

            while (i < bemenoszam)
            {
                Console.Write(i++ + " ");
                //i = i + 1;
                //i += 1;
                //i++;
            }
            Console.ReadKey(true);*/

            //15.feladat (Hátultesztelős ciklus)
            /* Console.Write("Kérem a pozitív egész számot: ");
             int bemenoszam = Int32.Parse(Console.ReadLine());

             int i = 1;

             do
             {
                 Console.Write(i++ + " ");
             } while (i < bemenoszam);
             Console.ReadKey(true);*/

            //16.feladat
            /*Console.Write("Kérem a pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());
            string kiiratas = "";

            for (int i = 0; i <= bemenoszam; i++)
            {
                kiiratas += "\t" + i + "\n"; //"\n" jelöli a sortörést, "\t" a tabulátort
            }
            Console.WriteLine(kiiratas);

            Console.ReadKey(true);*/

            //16.feladat (Elöltesztelő ciklus)
            /*Console.Write("Kérem a pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());

            int i = 1;

            while (i < bemenoszam)
            {
                Console.WriteLine(i++);
                //i = i + 1;
                //i += 1;
                //i++;
            }
            Console.ReadKey(true);*/

            //16.feladat (Hátultesztelős ciklus)
            /*Console.Write("Kérem a pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());

            int i = 1;

            do
            {
                Console.WriteLine(i++);
            } while (i < bemenoszam);
            Console.ReadKey(true);*/

            //17.feladat
            /*Console.WriteLine("Kérek egy pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{bemenoszam} egész osztói: ");

            for (int i = 1; i <= bemenoszam; i++)
            {
                if (bemenoszam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);*/

            //+feladat: Pozitív egész szám prímszám-e?
            /*Console.Write("Kérek egy pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());

            int szamlalo = 0;
            for (int i = 1; i < bemenoszam + 1; i++)
            {
                if (bemenoszam % i == 0)
                {
                    szamlalo++;
                }
            }
            
                if (szamlalo == 2)
                {
                    Console.WriteLine($"A bemenő szám ({bemenoszam}) prímszám.");
                }
                else
                {
                    Console.WriteLine($"A bemenő szám ({bemenoszam}) nem prímszám.");
                }
            Console.ReadKey(true);*/

            //18.feladat + +feladat
            /*Console.Write("Kérek egy pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());

            int szamlalo = 0;
            int osztokosszege = 0;
            for (int i = 1; i < bemenoszam + 1; i++)
            {
                if (bemenoszam % i == 0)
                {
                    szamlalo++;
                    osztokosszege += i;
                }
            }

            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám ({bemenoszam}) prímszám.");
                Console.WriteLine($"A szám osztóinak összege: ({osztokosszege})");
            }
            else
            {
                Console.WriteLine($"A bemenő szám ({bemenoszam}) nem prímszám.");
                Console.WriteLine($"A szám osztóinak összege: ({osztokosszege})");
            }
            Console.ReadKey(true);*/

            //19.feladat - ROSSZ
            /*Console.Write("Kérek egy pozitív egész számot: ");
            int bemenoszam = Int32.Parse(Console.ReadLine());
            int osztokosszege = 0;

            int i = 0;

            while (i <= bemenoszam)
            {
                if (bemenoszam % i == 0)
                {
                    osztokosszege += i;
                }
                i++;
            }

            if (osztokosszege == 2 * bemenoszam)
            {
                Console.WriteLine($"{bemenoszam} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"{bemenoszam} tökéletes szám.");
            }
            Console.ReadKey(true);*/

            //20.feladat
            /*Console.Write("Kérem a hatvány alapját: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a kitevőt: ");
            int k = Int32.Parse(Console.ReadLine());

            int hatvany = 1;

            for (int i = 0; i < k; i++)
            {
                hatvany *= a;
            }
            Console.WriteLine($"A hatvány: {hatvany}");

            Console.ReadKey(true);*/

            /*int a = -1;
            while (a <= 0 || a >= 10)
            {
                Console.Write("Kérem az alapot: ");
                a = Int32.Parse(Console.ReadLine());
            }
            int k = -1;
            while (k <= 0 || k >= 10)
            {
                Console.Write("Kérem a kitevőt: ");
                k = Int32.Parse(Console.ReadLine());
            }

            int hatvany = 1;

            for (int i = 0; i < k; i++)
            {
                hatvany *= a;
            }
            Console.WriteLine($"A hatvány: {hatvany}");

            Console.ReadKey(true);*/

            //21.feladat
            /*int szam = 0;

            while (szam <= 0)
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey(true);*/


            /*int szam = 1;
              while (szam % 2 == 1 || szam % 2 == -1)
              {
                  Console.Write("Kérek egy pozitív egész számot: ");
                  szam = Convert.ToInt32(Console.ReadLine());
              }
              Console.ReadKey(true);*/

            //+ feladat: Prímszámra lépjen ki a ciklusból.
            /* int szam = 7;

               while (primszamE(szam))
               {
                   Console.Write("Kérek egy nem prím számot: ");
                   szam = Convert.ToInt32(Console.ReadLine());
               }

               Console.ReadKey(true);*/
            //22.feladat
            int szam = 0;
            int osszeg = 0;

            while (szam <= 10)
            {
                Console.WriteLine("Kérek egy 10-nél kisebb egész számot: ");
                szam = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Az eddig beolvasott számok összege: {osszeg}");

                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"Az eddig beolvasott mgefelelő számok összege: {osszeg}");
                }
                else
                {
                    Console.WriteLine("Nem megfelelő a szám.");
                    break;
                }
                Console.WriteLine($"A beolvasott számok összege: {osszeg}");
            }

            Console.ReadKey(true);

        }
        static bool primszamE(int szam)
        {
            bool teljesul = true;

            int osztokszama = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                    osztokszama++;
            }

            if (osztokszama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }
    }
}
