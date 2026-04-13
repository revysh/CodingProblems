using MaangProblems.Model;
using System.Collections;
using System.Net.Http.Headers;

namespace MaangProblems.MiddleOfLinkedList
{
    public class MiddleLinkedListProblem_Optimal
    {
        public ListNode Solve(ListNode head)
        {
            ListNode middle = head;
            ListNode end = head;
            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }
            return middle;
        }
    }
}
