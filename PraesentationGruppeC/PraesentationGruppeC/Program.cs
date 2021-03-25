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



                if (name == "Ming")

                {
                    Console.WriteLine("Hallo, Ming");//oder kann man auch sagen 你好，铭
                }
                else if (name == "Merve")
                {

                    Console.WriteLine("Hallo, Merve");//你好，美味我
                }
                else if (name == "Jonathan")//你好，雍堂涵
                {
                    Console.WriteLine("Hallo, Jonathan ");

                }
                else if (name == "Claude")
                {
                    Console.WriteLine("Hallo, Claude");//你好，克劳德
                }
                else
                {
                    Console.WriteLine("Du bist nicht in Gruppe C");//你不在C组中
                }
               
            }


            Console.ReadKey();
        }
    }
}
