using NUnit.Framework;
using System.Collections.Generic;
using MaangProblems._2798_EmployeeHoursTarget;

namespace MaangProblems.Tests._2798_EmployeeHoursTarget
{
    public class EmployeeHoursTargetTests
    {
        [TestCase(new[] { 0, 1, 2, 3, 4 }, 2, 3, TestName = "EmployeeHoursTarget 1")]
        [TestCase(new[] { 5, 1, 4, 2, 2 }, 6, 0, TestName = "EmployeeHoursTarget 2")]
        public void EmployeeHoursTarget_Test(int[] nums, int target, int expected)
        {
            var solver = new EmployeeHoursTargetProblem();
            var result = solver.EmployeeHoursTarget(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}