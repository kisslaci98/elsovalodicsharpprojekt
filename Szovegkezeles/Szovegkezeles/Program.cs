using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            //50. feladat
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i] + " ");
            }

            Console.Write('\b');

            Console.ReadKey(true);*/

            //51.feladat
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();
            Console.Write("Kérem a tabu karaktert: ");
            char taboo = Char.Parse(Console.ReadLine());

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != taboo)
                {
                    Console.Write(word[i]);
                }
            }

            Console.ReadKey(true);*/

            //52.feladat
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(word[i]);
                }
            }

            Console.ReadKey(true);*/

            //+feladat: adott indexű elem kiiratása
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();
            Console.Write("Kérem az indexet: ");
            int index = Int32.Parse(Console.ReadLine());

            if (index < word.Length)
            {
                Console.WriteLine("A keresett karakter: " + word[index]);
            }
            else
            {
                Console.WriteLine("Bocsi, de ilyen indexű karakter nincs.");
            }

            Console.ReadKey(true);*/

            //53.feladat
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();

            int i = 0;

            while (i < word.Length)
            {
                Console.WriteLine($"{word[i]} - {(int)word[i]}");
                i++;
            }

            Console.ReadKey(true);*/

            //54.feladat
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.ReadKey(true);*/

            //55.feladat
            /*Console.Write("Kérem, írjon be egy mondatot: ");
            string mondat = Console.ReadLine();

            for (int i = 0; i < mondat.Length; i++)
            {
                if ((int)mondat[i] != 32)
                {
                    Console.Write(mondat[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey(true);*/

            /*Console.Write("Kérem, írjon be egy mondatot: ");
            string mondat = Console.ReadLine();

            string[] tomb = mondat.Split(' ');

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.ReadKey(true);*/

            //56.feladat
            /*Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();
            string reverseWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            Console.WriteLine(reverseWord.ToUpper());
            Console.ReadKey(true);*/

            //57.feladat
            /*Console.Write("Kérem, írjon be egy mondatot: ");
            string mondat = Console.ReadLine();

            string[] tomb = mondat.Split(' ');

            for (int i = 0; i < tomb.Length; i++)
            {
                string elsoBetu = tomb[i].Substring(0, 1).ToUpper();
                string maradek = tomb[i].Substring(1);
                Console.WriteLine(elsoBetu + maradek);
                
            }
            Console.ReadKey(true);*/

            //+ feladat: Adott szóban minden második betű nagybetű.

            Console.Write("Kérek egy szót: ");
            string word = Console.ReadLine();
            string write = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 1)
                {
                    char ch = (char)((int)word[i] - 32);
                    write += ch;
                }
                else
                {
                    write += word[i];
                }
            }
            Console.WriteLine(write);

            Console.ReadKey(true);

        }
    }
}
