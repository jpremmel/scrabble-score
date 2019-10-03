using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Test
{
    [TestClass]
    public class ScrabbleScorerTest
    {
        ScrabbleScorer testScrabbleScorer = new ScrabbleScorer();

        [TestMethod]
        public void DetermineScore_IsAlphabetical_NegativeOne()
        {
            Assert.AreEqual(-1, testScrabbleScorer.DetermineScore("10"));
        }

        [TestMethod]
        public void DetermineScore_SingleLetter_2()
        {
            Assert.AreEqual(2, testScrabbleScorer.DetermineScore("d"));
        }

        [TestMethod]
        public void DetermineScore_WholeWord_5()
        {
            Assert.AreEqual(5, testScrabbleScorer.DetermineScore("cat"));
        }
    }
}