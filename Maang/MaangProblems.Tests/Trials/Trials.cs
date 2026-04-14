
using NUnit.Framework;
using MaangProblems.Trials;

namespace MaangProblems.Tests.Trials
{
    public class TrialsTests
    {
        [TestCase(new[] { 1, 1, 0, 1, 1, 1 }, 3, TestName = "Trials 1")]
        public void Trials_Test(int[] nums, int expected)
        {
            var solver = new TrialsProblem();
            var result = solver.Solve(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
