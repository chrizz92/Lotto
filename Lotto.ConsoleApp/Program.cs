using System;

namespace Lotto.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tippedNumbers = new int[6];
            int[] lotto = new int[6];
            int[] lottoCounter = new int[7];
            int numberOfGames;
            int counter;
            Random rand = new Random();

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

            /**
            Console.Write("Dein Tipp:{0,-7}","");
            for(int j = 0; j < tippedNumbers.Length; j++)
            {
                Console.Write("{0,3}", tippedNumbers[j]);
            }
            Console.WriteLine("\n");
            **/

            //LOTTOZIEHUNG
            Console.Write("Wie viele Ziehungen lang wollen sie teilnehmen: ");
            numberOfGames = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            for(int m = numberOfGames; m > 0; m--)
            {
                counter = 0;
                Console.Write("Ziehung Nr. {0,3}{1,-2}",numberOfGames-m+1,"");
                for (int n = 0; n < 6; n++)
                {
                    do
                    {
                        lotto[n] = rand.Next(1, 46);
                        for (int o = 0; o < n; o++)
                        {
                            
                            if (lotto[o] == lotto[n])
                            {
                                lotto[n] = 0;
                                
                            }
                        }
                    } while (lotto[n] < 1 || lotto[n] > 45);

                    Console.Write("{0,3}", lotto[n]);
                }
                
                for(int p = 0; p < lotto.Length; p++)
                {
                    for(int r = 0; r < tippedNumbers.Length; r++)
                    {
                        if (lotto[p] == tippedNumbers[r])
                        {
                            counter++;
                        }
                    }
                }

                Console.WriteLine("   Ergebnis: {0} Richtige", counter);
                lottoCounter[counter]++;
            }

            //GESAMTERGEBNIS
            Console.WriteLine("\nGesamtergebnis:");
            for(int s = 0; s < lottoCounter.Length; s++)
            {
                Console.Write("{0} Richtige: {1,-7}", s,lottoCounter[s]);
                if (s == 2)
                {
                    Console.WriteLine();
                }
            }
          

            

        }
    }
}
