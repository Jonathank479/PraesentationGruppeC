using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraesentationGruppeC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihren Namen ein");

            string name;
            name = Console.ReadLine();

            if (name == "Merve")
                Console.WriteLine("Hallo, Merve");
            if (name == "Jonathan")
                Console.WriteLine("Hallo, Jonathan");
            else
                Console.WriteLine("Du bist nicht in Gruppe C");
            
            Console.ReadKey();
        }
    }
}
