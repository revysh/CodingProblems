using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._0020_ValidParentheses;

namespace MaangProblems.Tests._0020_ValidParentheses
{
    public class ValidParenthesesTests
    {
        [TestCase("()", true, TestName = "Valid Parentheses 1")]
        [TestCase("()[]{}", true, TestName = "Valid Parentheses 2")]
        [TestCase("(]", false, TestName = "Valid Parentheses 3")]
        [TestCase("([])", true, TestName = "Valid Parentheses 4")]
        [TestCase("([)]", false, TestName = "Valid Parentheses 5")]
        [TestCase("((", false, TestName = "Valid Parentheses 6")]
        [TestCase("}}", false, TestName = "Valid Parentheses 7")]
        public void ValidParentheses_Test(string input, bool expected)
        {
            var solver = new ValidParenthesesProblem();
            var result = solver.IsValid(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}