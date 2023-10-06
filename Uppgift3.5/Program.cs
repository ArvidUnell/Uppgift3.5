using System;
namespace Uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal separerade med ett semikolon");
            string talStr = Console.ReadLine();

            float tal1 = float.Parse(talStr[..talStr.IndexOf(';')]);
            float tal2 = float.Parse(talStr[(talStr.IndexOf(";")+1)..]);

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");
            byte räknesätt = byte.Parse(Console.ReadLine());

            switch (räknesätt)
            {
                case 1:                  
                    Console.WriteLine($"Svar: {tal1 + tal2}.");
                    break;

                case 2:
                    Console.WriteLine($"Svar: {tal1 - tal2}.");
                    break;

                case 3:
                    Console.WriteLine($"Svar: {tal1 * tal2}.");
                    break;

                case 4:
                    Console.WriteLine($"Svar: {tal1 / tal2}.");
                    break;

                default:
                    Console.WriteLine($"{räknesätt} är inte ett giltigt räknesätt.");
                    break;
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta.");
            Console.ReadKey();
        }
    }
}