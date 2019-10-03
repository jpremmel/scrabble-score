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
        int score = scorer.DetermineScore(input);
        if (score == -1)
        {
            Console.WriteLine("Alphabetical input only. Please try again.");
            Main();
        }
        else 
        {
            Console.WriteLine("Your score is: " + score);
        }
        

    }
}