
namespace MaangProblems.NumberOfSteps
{
    public class BitwiseNumberOfStepsProblem
    {
        public int Solve(int num)
        {
            int stepCount = 0;
            while (num != 0)
            {
                if ((num & 1) == 0)
                    num = num >> 1; 
                    //Halves as we shift bits to right
                    //Doubles as we shift bits left
                else
                    num--;
                stepCount++;
            }
            return stepCount;
        }

    }
}
