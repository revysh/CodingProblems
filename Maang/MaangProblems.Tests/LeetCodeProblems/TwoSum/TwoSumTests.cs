using MaangProblems.LeetCodeProblems.TwoSum;

namespace MaangProblems.Tests.LeetCodeProblems.TwoSum
{
    public class TwoSumTests
    {
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 }, TestName = "TwoSum_Test 1")]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 }, TestName = "TwoSum_Test 2")]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 }, TestName = "TwoSum_Test 3")]
        public void TwoSum_Test(int[] nums, int target, int[] expected)
        {
            var solver = new TwoSumProblem();
            var result = solver.Solve(nums, target);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
