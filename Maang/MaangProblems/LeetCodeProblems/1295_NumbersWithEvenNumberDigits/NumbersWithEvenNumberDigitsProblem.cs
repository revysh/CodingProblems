using System.Collections.Generic;

namespace MaangProblems._1295_NumbersWithEvenNumberDigits
{
    public class NumbersWithEvenNumberDigitsProblem
    {
        public int NumbersWithEvenNumberDigits(int[] nums)
        {
            int counter = 0;
            foreach (int num in nums)
                if ((int)Math.Log10(num) % 2 == 1) counter++;
            return counter;
        }
    }
}