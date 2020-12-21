using System;
using System.IO;


namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine();

            Console.Write("Pick a number of coin flips ");
            int numberOfFlips = int.Parse(Console.ReadLine());

            // where the work happens
            int headscount = 0;
            int tailscount = 0;
            int counter = headscount;
            int counter1 = tailscount;

            Random rnd = new Random();
            for (int i = 0; i < numberOfFlips; i++)
            {
                if (rnd.Next() % 2 == 0)
                {
                    Console.WriteLine("heads");
                    headscount++;
                }
                else
                {
                    Console.WriteLine("tails");
                    tailscount++;
                }
            }
            int correctCount = 0;
            int counter2 = correctCount;
          
            { if (headsOrTailsGuess == "heads") 
                { correctCount = headscount; }
            else
                { correctCount = tailscount;
                } 
            }
            Console.Write("Your guess: " + headsOrTailsGuess);
            Console.Write(" Correct guesses: " + correctCount);

            int percent = correctCount/numberOfFlips;
           
            Console.WriteLine(" Percentage correct: " + percent );
            
        }
                   
                }
            }
        
    
