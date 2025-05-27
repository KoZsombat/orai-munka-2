using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Nem { get; set; }
        public List<Eredmeny> Eredmenyek { get; set; } = new List<Eredmeny>();
        public Versenyzo(string nev, int kor, string nem)
        {
            Nev = nev;
            Kor = kor;
            Nem = nem;
        }
    }
}
