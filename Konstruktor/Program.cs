using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            OsOsztaly osPeldany = new OsOsztaly(23, "szöveg");

            GyermekOsztaly gyPeldany = new GyermekOsztaly(20);

            Console.ReadKey();

        }
    }
}
