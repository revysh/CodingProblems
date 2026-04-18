using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MaangProblems._0680_ValidPalindromeII
{
    public class ValidPalindromeIIProblem
    {
        public bool ValidPalindrome(string s)
        {
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return IsPalindrome(s, left + 1, right)
                || IsPalindrome(s, left, right - 1);
                }
            }
            return true;
        }

        private bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    }
}