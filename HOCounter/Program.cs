using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h','o','l' tähte lauses "Hello, world!"
            int counter1 = 0;
            int counter2= 0;
            int counter3= 0;
            string helloW = "Hello, world!";

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'h')
                {
                    counter1++; // counter = counter + 1
                }
                else if (helloW[i] == 'o')
                {
                    counter2++; // counter = counter + 1
                }
                else if (helloW[i] == 'l')
                {
                    counter3++; // counter = counter + 1
                }
                else
                {
                    continue;
                }
                


            }
            Console.WriteLine($"Lauses on {counter1} h, {counter2} o, {counter3} l  täht.");

        }
    }
}
