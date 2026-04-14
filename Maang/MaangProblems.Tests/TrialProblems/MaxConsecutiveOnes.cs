
using NUnit.Framework;
using MaangProblems.MaxConsecutiveOnes;

namespace MaangProblems.Tests.MaxConsecutiveOnes
{
    public class MaxConsecutiveOnesTests
    {
        [TestCase(new[] { 1, 1, 0, 1, 1, 1 }, 3, TestName = "Max Consecutive Ones 1")]
        public void MaxConsecutiveOnes_Test(int[] nums, int expected)
        {
            var solver = new MaxConsecutiveOnesProblem();
            var result = solver.Solve(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
