using System;
namespace Uppgift_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string val = Console.ReadLine();
            int ålder = int.Parse(val);

            if (ålder == 15)
            {
                Console.WriteLine("Du få komma in");
            }

            else if (ålder == 16)
            {
                Console.WriteLine("Du får komma in");
            }

            else if (ålder == 17)
            {
                Console.WriteLine("Du får komma in ");
            }
            
            else if (ålder == 18)
            {
                Console.WriteLine("Du får komma in");
            }

            else if (ålder == 19)
            {
                Console.WriteLine("Du får komma in");
            }

            else
            {
                Console.WriteLine("Ajabaja, du är inte välkommen in, eftersom du inte är mellan 16-19 år gammal");

            }
        }
    }
}