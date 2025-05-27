using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Verseny
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public int MaxIndulo { get; set; }
        public List<Versenyzo> Indulok { get; set; } = new List<Versenyzo>();
        public Verseny(string nev, string kategoria, int maxIndulo)
        {
            Nev = nev;
            Kategoria = kategoria;
            MaxIndulo = maxIndulo;
        }
        public void HozzaadVersenyzo(Versenyzo versenyzo)
        {
            if (Indulok.Count < MaxIndulo)
            {
                Indulok.Add(versenyzo);
            }
            else
            {
                Console.WriteLine("A verseny megtelt, nem lehet több indulót hozzáadni.");
            }
        }
    }
}
