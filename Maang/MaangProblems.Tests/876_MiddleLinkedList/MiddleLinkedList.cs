
using NUnit.Framework;
using MaangProblems.MiddleOfLinkedList;
using MaangProblems.Model;

namespace MaangProblems.Tests.MiddleOfLinkedList
{
    public class MiddleOfLinkedListTests
    {
        [TestCaseSource(nameof(Data))]
        public void MiddleOfLinkedList_Test(ListNode node, ListNode expected)
        {
            var solver = new MiddleOfLinkedListProblem();
            var result = solver.Solve(node);
            Assert.That(ToArray(result), Is.EqualTo(ToArray(expected)));
        }

        private static IEnumerable<TestCaseData> Data()
        {
            yield return new TestCaseData(
                BuildList(1, 2, 3, 4, 5),
                BuildList(3, 4, 5))
                .SetName("Odd length 1");

            yield return new TestCaseData(
                BuildList(1, 2, 3, 4, 5, 6),
                BuildList(4, 5, 6))
                .SetName("Even length");

            yield return new TestCaseData(
                BuildList(3, 1, 7, 2, 2),
                BuildList(7, 2, 2))
                .SetName("Odd length 2");
        }

        private static ListNode BuildList(params int[] values)
        {
            var dummy = new ListNode(0);
            var current = dummy;
            foreach (var v in values)
            {
                current.next = new ListNode(v);
                current = current.next;
            }
            return dummy.next;
        }

        private static int[] ToArray(ListNode head)
        {
            var list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            return list.ToArray();
        }
    }
}
