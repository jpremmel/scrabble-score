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
                for(int j = 0; j < word.Length; j++)
                {
                    for(int i = 0; i < 10; i++)
                    {
                        if (word[j] == letters[i])
                        {
                            score ++;
                        }
                    }
                    for(int i = 12; i < 16; i++)
                    {
                        if (word[j] == letters[i])
                        {
                        score += 3;
                        }
                    }
                    for(int i = 16; i < 21; i++)
                    {
                        if (word[j] == letters[i])
                        {
                        score += 4;
                        }
                    }
                    if (word[j] == letters[10] || word[j] == letters[11])
                    {
                        score += 2;
                    }
                    if (word[j] == letters[21])
                    {
                        score += 5;
                    }
                    if (word[j] == letters[22] || word[j] == letters[23])
                    {
                        score += 8;
                    }
                    if (word[j] == letters[24] || word[j] == letters[25])
                    {
                        score += 10;
                    }
                }
            }
            return score;
        }
    }
}