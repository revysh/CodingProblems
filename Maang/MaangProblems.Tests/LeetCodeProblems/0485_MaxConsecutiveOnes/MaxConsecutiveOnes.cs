
using NUnit.Framework;
using MaangProblems._0485_MaxConsecutiveOnes;

namespace MaangProblems.Tests._485_MaxConsecutiveOnes
{
    public class MaxConsecutiveOnesTests
    {
        [TestCase(new[] { 1, 1, 0, 1, 1, 1 }, 3, TestName = "Max Consecutive Ones 1")]
        [TestCase(new[] { 1 }, 1, TestName = "Max Consecutive Ones 2")]
        [TestCase(new[] { 1, 0 }, 1, TestName = "Max Consecutive Ones 3")]
        public void MaxConsecutiveOnes_Test(int[] nums, int expected)
        {
            var solver = new MaxConsecutiveOnesProblem();
            var result = solver.Solve(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
