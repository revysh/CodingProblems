using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._1523_OddNumbersInInterval;

namespace MaangProblems.Tests._1523_OddNumbersInInterval
{
    public class OddNumbersInIntervalTests
    {
        [TestCase(3, 7, 3, TestName = "OddNumbersInInterval1")]
        [TestCase(8, 10, 1, TestName = "OddNumbersInInterval2")]
        public void OddNumbersInInterval_Test(int start, int end, int expected)
        {
            var solver = new OddNumbersInIntervalProblem();
            var result = solver.CountOdds(start, end);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}