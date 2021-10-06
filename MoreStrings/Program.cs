using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõppevad punktiga
            //--> Harry Potter --> H.P.

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Sisestada oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName[0]}. {lastName[0]}.");
        }
    }
}
