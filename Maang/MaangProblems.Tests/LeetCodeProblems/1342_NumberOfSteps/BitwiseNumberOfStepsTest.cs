using MaangProblems.NumberOfSteps;

namespace MaangProblems.Tests.NumberOfSteps
{
    public class BitwiseNumberOfStepsTest
    {
        [TestCase(14, 6, TestName = "1342_leetCode_bitwise_NumberOfSteps_Test 1")]
        [TestCase(8, 4, TestName = "1342_leetCode_bitwise_NumberOfSteps_Test 2")]
        [TestCase(30, 8, TestName = "1342_leetCode_bitwise_NumberOfSteps_Test 3")]
        [TestCase(123, 12, TestName = "1342_leetCode_bitwise_NumberOfSteps_Test 4")]
        public void BitwiseNumberOfSteps_Test(int num, int expected)
        {
            var solver = new BitwiseNumberOfStepsProblem();
            var result = solver.Solve(num);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
