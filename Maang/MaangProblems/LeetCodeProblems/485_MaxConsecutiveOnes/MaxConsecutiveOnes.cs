
namespace MaangProblems._485_MaxConsecutiveOnes
{
    public class MaxConsecutiveOnesProblem
    {
        public int Solve(int[] nums)
        {
            int maxLength = 0;
            int currentMax = 0;
            foreach (int x in nums)
            {
                currentMax = x==1? currentMax + 1:0;
                maxLength =  currentMax > maxLength ? currentMax : maxLength;
            }
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == 1)
            //    {
            //        currentMax++;
            //        if (currentMax > maxLength)
            //            maxLength = currentMax;
            //    }
            //    else
            //    {
            //        currentMax = 0;
            //    }
            //}
            return maxLength;
        }
    }
}
