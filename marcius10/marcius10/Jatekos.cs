using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marcius10
{
    class Jatekos
    {
        public string Nev { get; set; }
        public string Elso { get; set; }
        public string Utolso { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Jatekos(string n, string e, string u, int s, int m)
        {
            this.Nev = n;
            this.Elso = e;
            this.Utolso = u;
            this.Suly = s;
            this.Magassag = m;
        }
    }
}
