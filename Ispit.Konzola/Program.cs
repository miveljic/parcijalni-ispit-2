using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        public static void TestirajTelefon(IPametniTelefon telefon)
        {
            Console.Write("Unesite broj telefona: ");
            string telefonski_broj = Console.ReadLine();
            Console.WriteLine(telefon.Poziv(telefonski_broj));

            Console.Write("Unesite url: ");
            string url = Console.ReadLine();
            Console.WriteLine(telefon.Surfanje(url));
        }
        static void Main(string[] args)
        {
            while (true)
            {
                PametniTelefon telefon = new PametniTelefon("IPhone");
                TestirajTelefon(telefon);
                Console.WriteLine();
            }
        }
    }
}
