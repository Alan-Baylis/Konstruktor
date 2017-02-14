using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konstruktor
{
    class GyermekOsztaly : OsOsztaly
    {
        /// <summary>
        /// 1 paraméteres konstruktor, int-et vár és lefuttatja az ős konstruktorát is
        /// </summary>
        /// <param name="szam"></param>
        public GyermekOsztaly(int szam) : base(szam)
        {
            Console.WriteLine("GYermek 1param konstruktor");
        }
        /// <summary>
        /// BAZDMEG
        /// </summary>
        /// <param name="szam">számot adj</param>
        /// <param name="szoveg">szöveget!</param>
        public GyermekOsztaly(int szam, string szoveg) : base(szam, szoveg)
        {
            //TODO: csinád meg!

            Console.WriteLine("GYermek 2 param konstruktor");
        }

        protected GyermekOsztaly()
        {
        }
    }
}
