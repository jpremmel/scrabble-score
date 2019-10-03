//backend
using System.Text.RegularExpressions;

namespace Scrabble
{
    public class ScrabbleScorer
    {
        public int DetermineScore(string input)
        {
            int score = 0;
            char[] letters = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't', 'd', 'g', 'b', 'c', 'm', 'p', 'f', 'h', 'v', 'w', 'y', 'k', 'j', 'x', 'q', 'z'};
            Regex regex = new Regex(@"[^a-zA-Z]");
            Match match = regex.Match(input);
            if (match.Success || input.Length < 1){
               score = -1;
            }
            else
            {
                string word = input.ToLower();
                for(int i = 0; i < 10; i++)
                {
                    if (word[0] == letters[i])
                    {
                        score ++;
                    }
                }
                for(int i = 12; i < 16; i++)
                {
                    if (word[0] == letters[i])
                    {
                       score += 3;
                    }
                }
                for(int i = 16; i < 21; i++)
                {
                    if (word[0] == letters[i])
                    {
                       score += 4;
                    }
                }
                if (word[0] == letters[10] || word[0] == letters[11])
                {
                    score += 2;
                }
                if (word[0] == letters[21])
                {
                    score += 5;
                }
                if (word[0] == letters[22] || word[0] == letters[23])
                {
                    score += 8;
                }
                if (word[0] == letters[24] || word[0] == letters[25])
                {
                    score += 10;
                }
            }
            return score;
        }
    }
}