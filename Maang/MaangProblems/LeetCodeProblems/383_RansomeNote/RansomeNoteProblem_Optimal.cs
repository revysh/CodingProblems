
using System.Collections;
using System.Net.Http.Headers;

namespace MaangProblems.RansomeNote
{
    public class RansomeNoteProblem_Optimal
    {
        public bool Solve(string ransomNote, string magazine)
        {
            int[] count = new int[26];
            foreach (char c in magazine)
                count[c - 'a']++;

            foreach (char c in ransomNote)
                if (--count[c - 'a'] < 0)
                    return false;
            return true;
        }

    }
}
