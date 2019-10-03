//backend
using System.Text.RegularExpressions;

namespace Scrabble
{
    public class ScrabbleScorer
    {
        public int DetermineScore(string input)
        {
            int score = 0;
            Regex regex = new Regex(@"[^a-zA-Z]");
            Match match = regex.Match(input);
            if (match.Success || input.Length < 1){
               score = -1;
            }
            else
            {

            }
            return score;
        }
    }
}