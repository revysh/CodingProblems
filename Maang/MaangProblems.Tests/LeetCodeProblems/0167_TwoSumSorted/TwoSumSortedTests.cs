using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._0167_TwoSumSorted;

namespace MaangProblems.Tests._0167_TwoSumSorted
{
    public class TwoSumSortedTests
    {
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 }, TestName = "TwoSumSorted_Test 1")]
        [TestCase(new[] { 2, 3, 4 }, 6, new[] { 1, 3}, TestName = "TwoSumSorted_Test 2")]
        [TestCase(new[] { 5, 25, 75 }, 100, new[] { 2, 3 }, TestName = "TwoSumSorted_Test 3")]
        public void TwoSumSorted_Test(int[] nums, int target, int[] expected)
        {
            var solver = new TwoSumSortedProblem();
            var result = solver.TwoSumSorted(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> Data()
        {
            yield return new TestCaseData(
                new int[] { 2, 7, 11, 15 },
                9,
                new int[] { 0, 1 })
                .SetName("TwoSumSorted_Test 1");
        }
    }
}