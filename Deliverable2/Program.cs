using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine();

            Console.Write("Pick a number 1-10 ");
            int numberOfFlips = int.Parse(Console.ReadLine());
        }
    }
}
