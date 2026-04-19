using System.Collections.Generic;

namespace MaangProblems._0167_TwoSumSorted
{
    public class TwoSumSortedProblem
    {
        public int[] TwoSumSorted(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] == target)
                    return [left + 1, right + 1];
                if (nums[left] + nums[right] < target)
                    left++;
                else right--;
            }
            return null;
        }
    }
}