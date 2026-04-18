using MaangProblems._0680_ValidPalindromeII;

namespace MaangProblems.Tests._0680_ValidPalindromeII
{
    public class ValidPalindromeIITests
    {
        [TestCase("abca", true, TestName = "ValidPalindrome 1")]
        [TestCase("aba", true, TestName = "ValidPalindrome 2")]
        [TestCase("abc", false, TestName = "ValidPalindrome 3")]
        [TestCase("zryxeededexyz", false, TestName = "ValidPalindrome 4")]
        [TestCase("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga", true, TestName = "ValidPalindrome 5")]
        [TestCase("cupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupucu", true, TestName = "ValidPalindrome 6")]
        public void ValidPalindrome_Test(string input, bool expected)
        {
            var solver = new ValidPalindromeIIProblem();
            var result = solver.ValidPalindrome(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}