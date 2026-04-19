using System.Collections.Generic;

namespace MaangProblems._2798_EmployeeHoursTarget
{
    public class EmployeeHoursTargetProblem
    {
        public int EmployeeHoursTarget(int[] hours, int target)
        {
            int employeeCount = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                    employeeCount++;
            }
            return employeeCount;
        }
    }
}