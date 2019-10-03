//frontend
using System;
using Scrabble;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a word:");
        string input = Console.ReadLine();
        ScrabbleScorer scorer = new ScrabbleScorer();
        if (scorer.DetermineScore(input) == -1)
        {
            Console.WriteLine("Alphabetical input only. Please try again.");
        }
        

    }
}