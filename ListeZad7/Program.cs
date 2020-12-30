using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gradovi = new Dictionary<string, int>()
            {
                    {"Beograd", 2000000},
                    {"Nis", 1400000 },
                    {"Kraljevo", 400000 }
            };
            Console.WriteLine(gradovi["Nis"]);
            Console.WriteLine("=======================================");

            int brStanovnika;
            bool found = gradovi.TryGetValue("Novi Sad", out brStanovnika);

            if (found)
                Console.WriteLine(brStanovnika);
            else
                Console.WriteLine("Ne postoji trazeni kljuc");

            Console.ReadLine();
        }
    }
}
