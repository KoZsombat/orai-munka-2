using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Eredmeny
    {
        public string VersenyNev { get; set; }
        public TimeSpan Ido { get; set; }
        public int Helyezes { get; set; }
        public Eredmeny(string versenyNev, string ido, int helyezes)
        {
            VersenyNev = versenyNev;
            Ido = TimeSpan.ParseExact(ido, "c", CultureInfo.InvariantCulture);
            Helyezes = helyezes;
        }
    }
}
