using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._0026_RemoveDuplicatesSortedArray;

namespace MaangProblems.Tests._0026_RemoveDuplicatesSortedArray
{
    public class RemoveDuplicatesSortedArrayTests
    {
        [TestCase(new[] { 1, 1, 2 }, 2, TestName = "Max Consecutive Ones 1")]
        [TestCase(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, TestName = "Max Consecutive Ones 2")]
        public void RemoveDuplicatesSortedArray_Test(int[] nums, int expected)
        {
            var solver = new RemoveDuplicatesSortedArrayProblem();
            var result = solver.RemoveDuplicatesSortedArray(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}