using System;

namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skirv in en sträng.");
            string sträng = Console.ReadLine();
            Console.WriteLine("Skriv in två tecken. (ac t.ex)");
            string teckenText = Console.ReadLine();
            string tecken1 = teckenText[..1];
            string tecken2 = teckenText[1..];

            if (sträng.Contains(tecken1) && sträng.Contains(tecken2))
                Console.WriteLine($"Strängen innehåller både {tecken1} och {tecken2}.");
            else if (sträng.Contains(tecken1))
                Console.WriteLine($"Strängen innehåller endast {tecken1}.");
            else if (sträng.Contains(tecken2))
                Console.WriteLine($"Strängen innehåller endast {tecken2}.");
            else
                Console.WriteLine("Inget av dina tecken finns i strängen.");

            Console.ReadKey();
        }
    }
}