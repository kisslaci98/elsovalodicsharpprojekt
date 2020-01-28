using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int i, l;

            Console.Write("Kérek egy mondatot: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {

                str1 = str1 + str[i];


            }

            Console.WriteLine(str1);
            

            Console.ReadKey(true);
        }
    }   
}
