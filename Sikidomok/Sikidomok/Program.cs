using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Negyzet negyzet = new Negyzet(12);
            Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");
            Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");

            Teglalap teglalap = new Teglalap(12, 10);
            Console.WriteLine($"A téglalap kerülete: {teglalap.KeruletSzamol()}");
            Console.WriteLine($"A téglalap területe: {teglalap.TeruletSzamol()}");*/

            Negyzet negyzet = new Teglalap(10, 15);

            Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");
            Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");

            Console.ReadKey(true);
        }
    }

    class Negyzet
    {
        public int AOldal { get; set; }
        public Negyzet(int AOldal)
        {
            this.AOldal = AOldal;
        }
        public int TeruletSzamol()
        {
            return this.AOldal * this.AOldal;
        }
        public int KeruletSzamol()
        {
            return this.AOldal * 4;
        }
        public void Kiir(Negyzet negy)
        {
            Console.WriteLine($"A négyzet kerülete: {negy.KeruletSzamol()}");
        }
        
    }
    class Teglalap : Negyzet
    {
        public int BOldal { get; set; }
        public Teglalap(int AOldal, int BOldal) : base(AOldal)
        {
            this.BOldal = BOldal;
        }
        new public int TeruletSzamol()
        {
            return this.AOldal * this.BOldal;
        }
        new public int KeruletSzamol()
        {
            return (this.AOldal + this.BOldal) * 2;
        }
        new public void Kiir (Negyzet negy)
        {
            Console.WriteLine($"A négyzet kerülete: {negy.KeruletSzamol()}");
        }
    }
}
