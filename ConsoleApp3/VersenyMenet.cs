using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class VersenyMenet
    {
        public List<Verseny> versenyek = new List<Verseny>();

        public void VersenyHozzaadasa(Verseny verseny)
        {
            versenyek.Add(verseny);
        }

        public void VersenyekListazasa()
        {
            foreach (var verseny in versenyek)
            {
                Console.WriteLine($"Verseny neve: {verseny.Nev}, Kategória: {verseny.Kategoria}, Max indulók: {verseny.MaxIndulo}");
                Console.WriteLine("Indulók:");
                foreach (var induló in verseny.Indulok)
                {
                    Console.WriteLine($"- {induló.Nev}, Kor: {induló.Kor}, Nem: {induló.Nem}");
                }
            }
        }

        public void VersenyEredmenyekKiirasa()
        {
            foreach (var verseny in versenyek)
            {
                Console.WriteLine($"Verseny neve: {verseny.Nev}, Kategória: {verseny.Kategoria}, Max indulók: {verseny.MaxIndulo}");
                Console.WriteLine("\nEredmények:");
                foreach (var v in verseny.Indulok)
                {
                    foreach (var e in v.Eredmenyek)
                    {
                        Console.WriteLine($"{v.Nev}: {e.VersenyNev} - {e.Ido} - {e.Helyezes}. hely");
                    }
                }
            }
        }
    }
}
