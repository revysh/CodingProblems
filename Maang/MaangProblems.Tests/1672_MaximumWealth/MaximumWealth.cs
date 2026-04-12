using MaangProblems._1672_MaximumWealth;

namespace MaangProblems.Tests._1672_MaximumWealth
{
    public class MaximumWealth
    {
        [TestCaseSource(nameof(MaximumWealth_Data))]
        public void MaximumWealth_Test(int[][] accounts, int expected)
        {
            var solver = new MaximumWealthProblem();
            var result = solver.Solve(accounts);
            Assert.That(result, Is.EqualTo(expected));
        }

        static IEnumerable<TestCaseData> MaximumWealth_Data()
        {
            yield return new TestCaseData(
                new int[][] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } },
                6
            ).SetName("1672_MaximumWealth_1");

            yield return new TestCaseData(
                new int[][] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } },
                10
            ).SetName("1672_MaximumWealth_2");

            yield return new TestCaseData(
                new int[][] { new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 } },
                17
            ).SetName("1672_MaximumWealth_3");
        }
    }

}
