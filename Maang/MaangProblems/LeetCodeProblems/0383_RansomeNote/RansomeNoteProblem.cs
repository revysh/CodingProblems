
using System.Collections;
using System.Net.Http.Headers;

namespace MaangProblems._0383_RansomeNote
{
    public class RansomeNoteProblem
    {
        public bool Solve(string ransomNote, string magazine)
        {
            Dictionary<char, int> found = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                char magazineCurrentChar = magazine[i];
                if (found.Count > 0 && found.ContainsKey(magazineCurrentChar))
                    found[magazineCurrentChar]++;
                else
                    found.Add(magazineCurrentChar, 1);
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                char ransomNoteCurrentChar = ransomNote[i];
                if (found.ContainsKey(ransomNoteCurrentChar) && found[ransomNoteCurrentChar] != 0)
                    found[ransomNoteCurrentChar]--;
                else
                    return false;
            }
            return true;
        }

    }
}
