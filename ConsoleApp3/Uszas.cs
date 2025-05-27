using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Uszas : Verseny
    {
        public Uszas(string nev, string kategoria, int maxIndulo) : base(nev, kategoria, maxIndulo)
        {

        }

        public string KiirUtasitas()
        {
            return "A versenzők 3 hossz úszással folytatják a versenyt.";
        }
    }
}
