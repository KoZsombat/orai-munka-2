using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>
            {
                new Versenyzo("Ember 0", 20, "férfi"),
                new Versenyzo("Ember 1", 66, "férfi"),
                new Versenyzo("Ember 2", 23, "nő")
            };

            Futas futas = new Futas("Tavaszi Futás", "Futás", 10);
            Uszas uszas = new Uszas("Tavaszi Uszás", "Úszás", 10);
            Kerekpar kerekpar = new Kerekpar("Tavaszi Kerékparozás", "Kerékpározás", 10);

            foreach (var v in versenyzok)
            {
                futas.HozzaadVersenyzo(v);
                uszas.HozzaadVersenyzo(v);
                kerekpar.HozzaadVersenyzo(v);
            }

            VersenyMenet versenyMenet = new VersenyMenet();
            versenyMenet.VersenyHozzaadasa(futas);
            versenyMenet.VersenyHozzaadasa(uszas);
            versenyMenet.VersenyHozzaadasa(kerekpar);

            versenyMenet.VersenyekListazasa();

            Console.WriteLine(futas.KiirUtasitas());

            versenyzok[0].Eredmenyek.Add(new Eredmeny(futas.Nev, "00:12:34", 1));
            versenyzok[1].Eredmenyek.Add(new Eredmeny(futas.Nev, "00:13:10", 2));
            versenyzok[2].Eredmenyek.Add(new Eredmeny(futas.Nev, "00:14:05", 3));

            Console.WriteLine(uszas.KiirUtasitas());

            versenyzok[0].Eredmenyek.Add(new Eredmeny(uszas.Nev, "00:12:34", 1));
            versenyzok[1].Eredmenyek.Add(new Eredmeny(uszas.Nev, "00:13:10", 2));
            versenyzok[2].Eredmenyek.Add(new Eredmeny(uszas.Nev, "00:14:05", 3));

            Console.WriteLine(kerekpar.KiirUtasitas());

            versenyzok[0].Eredmenyek.Add(new Eredmeny(kerekpar.Nev, "00:12:34", 1));
            versenyzok[1].Eredmenyek.Add(new Eredmeny(kerekpar.Nev, "00:13:10", 2));
            versenyzok[2].Eredmenyek.Add(new Eredmeny(kerekpar.Nev, "00:14:05", 3));

            versenyMenet.VersenyEredmenyekKiirasa();

            Console.ReadKey();
        }
    }
}
