using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konstruktor
{
    class OsOsztaly
    {
        private int szam;
        private string szoveg;

        protected OsOsztaly() { Console.WriteLine("Üres ős konstruktor"); }

        public OsOsztaly(int szam)
        {
            this.szam = szam;
            Console.WriteLine("Szam-ot váró ős konstruktor");
        }

        public OsOsztaly(int szam, string szoveg):this()
        {
            this.szam = szam;
            this.szoveg = szoveg;
            Console.WriteLine("2 paramétert váró ős konstruktor");
        }
    }
}
