using System;

namespace Lotto.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tippedNumbers = new int[6];

            Console.WriteLine("Lottosimulation 6 aus 45");
            Console.WriteLine("========================");

            for(int i = 0; i < 6; i++)
            {
                do
                {
                    Console.Write("Bitte {0}. Tipp eingeben: ", i + 1);
                    tippedNumbers[i] = Convert.ToInt32(Console.ReadLine());

                    if (tippedNumbers[i] < 1 || tippedNumbers[i] > 45)
                    {
                        Console.WriteLine("Bitte gültige Nummer (1-45) eingeben!");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        if (tippedNumbers[k] == tippedNumbers[i])
                        {
                            tippedNumbers[i]=0;
                            Console.WriteLine("Die Nummer wurde schon gewählt!");
                        } 
                    }

                    

                } while (tippedNumbers[i] < 1 || tippedNumbers[i] > 45);
            }
            
            // TESTAUSGABE
            for(int m = 0; m < 6; m++)
            {
                Console.WriteLine(tippedNumbers[m]);
            }
        }
    }
}
