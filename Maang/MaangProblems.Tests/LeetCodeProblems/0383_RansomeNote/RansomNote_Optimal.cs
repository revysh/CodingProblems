using MaangProblems._0383_RansomeNote;
using NUnit.Framework;

namespace MaangProblems.Tests._0383_RansomeNote
{
    public class RansomeNoteTests_Optimal
    {
        [TestCase("god", "dodge", true, TestName = "383_leetCode_RasomeNote_Test 1")]
        [TestCase("aa", "ab", false, TestName = "383_leetCode_RasomeNote_Test 2")]
        [TestCase("aa", "aab", true, TestName = "383_leetCode_RasomeNote_Test 3")]
        [TestCase("darb", "badger", true, TestName = "383_leetCode_RasomeNote_Test 4")]
        public void RansomeNoteTests_Optimal_Test(string ransomNote, string magazine, bool expected)
        {
            var solver = new RansomeNoteProblem_Optimal();
            var result = solver.Solve(ransomNote, magazine);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
