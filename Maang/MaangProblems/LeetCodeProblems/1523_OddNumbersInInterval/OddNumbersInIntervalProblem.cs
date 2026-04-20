using System.Collections.Generic;

namespace MaangProblems._1523_OddNumbersInInterval
{
    public class OddNumbersInIntervalProblem
    {
        public int CountOdds(int start, int end)
        {
            if (start % 2 == 0)
                return (end - start + 1) / 2;
            else
                return (end - start) / 2 + 1;
        }
    }
}