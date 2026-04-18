using System.Collections.Generic;

namespace MaangProblems._0125_ValidPalindrome
{
    public class ValidPalindromeProblem
    {
        public bool ValidPalindrome(string input)
        {
            char[] chars = input.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;
            while(left < right)
            {
                char leftChar = chars[left];
                char rightChar = chars[right];

                while (left < right && !char.IsLetterOrDigit(leftChar))
                    leftChar = chars[++left];
                while (left < right && !char.IsLetterOrDigit(rightChar))
                    rightChar = chars[--right];

                if (char.ToLower(leftChar) == char.ToLower(rightChar))
                {
                    left++;
                    right--;
                    continue;
                }
                else
                    return false;
            }
            return true;
        }
    }
}