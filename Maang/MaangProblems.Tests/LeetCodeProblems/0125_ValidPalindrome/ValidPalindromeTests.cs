using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._0125_ValidPalindrome;

namespace MaangProblems.Tests._0125_ValidPalindrome
{
    public class ValidPalindromeTests
    {
        [TestCase("level", true, TestName = "ValidPalindrome 1")]
        [TestCase("ABAA", false, TestName = "ValidPalindrome 2")]
        [TestCase("deified", true, TestName = "ValidPalindrome 3")]
        [TestCase("Peep", true, TestName = "ValidPalindrome 4")]
        [TestCase("A man, a plan, a canal: Panama", true, TestName = "ValidPalindrome 5")]
        [TestCase("Marge, let's \"[went].\" I await {news} telegram.", true, TestName = "ValidPalindrome 6")]
        public void ValidPalindrome_Test(string input, bool expected)
        {
            var solver = new ValidPalindromeProblem();
            var result = solver.ValidPalindrome(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}