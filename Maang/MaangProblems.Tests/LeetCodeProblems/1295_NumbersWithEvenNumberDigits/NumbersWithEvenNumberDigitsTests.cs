using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._1295_NumbersWithEvenNumberDigits;

namespace MaangProblems.Tests._1295_NumbersWithEvenNumberDigits
{
    public class NumbersWithEvenNumberDigitsTests
    {
        [TestCase(new int[] { 12, 345, 2, 6, 7896 }, 2, TestName = "Numbers with even number digits 1")]
        [TestCase(new int[] { 555, 901, 482, 1771 }, 1, TestName = "Numbers with even number digits 2")]
        public void NumbersWithEvenNumberDigits_Test(int[] nums, int expected)
        {
            var solver = new NumbersWithEvenNumberDigitsProblem();
            var result = solver.NumbersWithEvenNumberDigits(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}