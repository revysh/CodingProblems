using MaangProblems._412_FizzBuzz;

namespace MaangProblems.Tests._412_FizzBuzz
{
    public class FizzBuzz
    {
        [TestCaseSource(nameof(FizzBuzz_Data))]
        public void FizzBuzz_Test(int n, string[] expected)
        {
            var solver = new FizzBuzzProblem();
            var result = solver.Solve(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        static IEnumerable<TestCaseData> FizzBuzz_Data()
        {
            yield return new TestCaseData(
                3,
                new[] { "1", "2", "Fizz" }
            ).SetName("412_LeetCode_FizzBuzz_Test 1");

            yield return new TestCaseData(
                5,
                new[] { "1", "2", "Fizz", "4", "Buzz" }
            ).SetName("412_LeetCode_FizzBuzz_Test 2");

            yield return new TestCaseData(
                15,
                new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }
            ).SetName("412_LeetCode_FizzBuzz_Test 3");
        }
    }
}
