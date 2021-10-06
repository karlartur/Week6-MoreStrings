using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnimi
            //programm küsib kasutajal sisestada perekonnanimi
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja perekonnanimes
            int counter = 0;
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName}{lastName}".ToLower();
           
           /* foreach(char c in fullName)
            {
                if(c == 'a')
                {
                    counter++;
                }
            }
            int a = counter;
            Console.WriteLine(a);*/
           for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    counter++; // counter = counter + 1
                }
            }
            if (counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' täht.");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte.");
            }
            
        }
    }
}
