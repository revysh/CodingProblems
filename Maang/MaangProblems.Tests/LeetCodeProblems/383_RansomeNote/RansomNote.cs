using NUnit.Framework;
using MaangProblems.RansomeNote;

namespace MaangProblems.Tests.RansomeNote
{
    public class RansomeNoteTests
    {
        [TestCase("god", "dodge", true, TestName = "383_leetCode_RasomeNote_Test 1")]
        [TestCase("aa", "ab", false, TestName = "383_leetCode_RasomeNote_Test 2")]
        [TestCase("aa", "aab", true, TestName = "383_leetCode_RasomeNote_Test 3")]
        [TestCase("darb", "badger", true, TestName = "383_leetCode_RasomeNote_Test 4")]
        public void RansomeNote_Test(string ransomNote, string magazine, bool expected)
        {
            var solver = new RansomeNoteProblem();
            var result = solver.Solve(ransomNote, magazine);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
