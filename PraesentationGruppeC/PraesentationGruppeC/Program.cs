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
            string name;
            name = Console.ReadLine();


            {


                if (name == "Ming") // MINGMING

                {
                    Console.WriteLine("Hallo, Ming");
                }
                else if (name == "Merve")
                {
                    Console.WriteLine("Hallo, Merve"); //hihhhhhh
                }
                else if (name == "Jonathan")
                {
                    Console.WriteLine("Hallo, Jonathan "); //KOMMENTAR
                }
                else if (name == "Claude")
                {
                    Console.WriteLine("Hallo, Claude");
                }
                else
                {
                    Console.WriteLine("Du bist nicht in Gruppe C");
                }
               
            }


            Console.ReadKey();
        }
    }
}
