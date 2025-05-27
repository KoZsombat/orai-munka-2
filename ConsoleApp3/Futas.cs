using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Futas : Verseny
    {
        public Futas(string nev, string kategoria, int maxIndulo) : base(nev, kategoria, maxIndulo)
        {
        }

        public string KiirUtasitas()
        {
            return "A versenzők 3 kör futással kezdik a versenyt.";
        }
    }
}
