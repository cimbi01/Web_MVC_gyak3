using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Diak> diakok = new List<Diak>()
            {
                new Diak() { Nev = "Jani", PontSzam=rnd.Next(0, 500)},
                new Diak() { Nev = "Béla", PontSzam=220},
                new Diak() { Nev = "Alpaka", PontSzam=230},
                new Diak() { Nev = "Csicska", PontSzam=250},
                new Diak() { Nev = "Aladár", PontSzam=rnd.Next(0, 500)},
                new Diak() { Nev = "Pöcsi", PontSzam=rnd.Next(0, 500)},
                new Diak() { Nev = "Dani", PontSzam=rnd.Next(0, 500)}
            };
            foreach (var item in diakok.OrderBy(diak => diak.Nev))
            {
                Console.WriteLine(item.Nev);
            };
            IEnumerable<Diak> diakok_280 = diakok.Where(diak => diak.PontSzam > 280).OrderBy(diak => diak.Nev);
            foreach (var item in diakok_280)
            {
                Console.WriteLine("Név {0}, Pont: {1}", item.Nev, item.PontSzam);
            };
            foreach (var item in diakok.Where(diak => diak.Nev[0] == 'A'))
            {
                Console.WriteLine("Név: {0}", item.Nev);
            }
            Console.ReadKey();
        }
    }
}
