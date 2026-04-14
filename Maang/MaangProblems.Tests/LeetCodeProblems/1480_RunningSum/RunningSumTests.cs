using MaangProblems._1480_RunningSum;

namespace MaangProblems.Tests._1480_RunningSum
{
    public class RunningSumTests
    {
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 }, TestName = "1480_LeetCode_RunningSum_Test 1")]
        [TestCase(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 }, TestName = "1480_LeetCode_RunningSum_Test 2")]
        [TestCase(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 }, TestName = "1480_LeetCode_RunningSum_Test 3")]
        public void RunningSum_Test(int[] nums, int[] expected)
        {
            var solver = new RunningSumProblem();
            var result = solver.Solve(nums);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
