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
        Console.WriteLine(scorer.DetermineScore(input));

    }
}