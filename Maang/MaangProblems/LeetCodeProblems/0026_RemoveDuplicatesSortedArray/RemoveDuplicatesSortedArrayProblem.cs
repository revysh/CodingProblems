using System.Collections.Generic;

namespace MaangProblems._0026_RemoveDuplicatesSortedArray
{
    public class RemoveDuplicatesSortedArrayProblem
    {
        public int RemoveDuplicatesSortedArray(int[] nums)
        {
            int slow = 0, uniqueCount = 1;
            int fast = 1;

            while (fast < nums.Length)
            {
                if (nums[slow] != nums[fast])
                {
                    slow++;
                    nums[slow] = nums[fast];
                    uniqueCount++;
                }
                else
                    fast++;
            }
            return uniqueCount;
        }
    }
}