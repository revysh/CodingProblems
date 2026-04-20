using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._2011_FinalValueAfterOperations;

namespace MaangProblems.Tests._2011_FinalValueAfterOperations
{
    public class FinalValueAfterOperationsTests
    {
        [TestCase(new[] { "--X", "X++", "X++" }, 1, TestName = "FinalValueAfterOperations 1")]
        [TestCase(new[] { "++X", "++X", "X++" }, 3, TestName = "FinalValueAfterOperations 2")]
        [TestCase(new[] { "X++", "++X", "--X", "X--" }, 0, TestName = "FinalValueAfterOperations 3")]
        public void FinalValueAfterOperations_Test(string[] operations, int expected)
        {
            var solver = new FinalValueAfterOperationsProblem();
            var result = solver.FinalValueAfterOperations(operations);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}