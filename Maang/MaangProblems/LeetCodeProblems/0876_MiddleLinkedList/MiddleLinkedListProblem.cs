using MaangProblems.Model;
using System.Collections;
using System.Net.Http.Headers;

namespace MaangProblems._0876_MiddleLinkedList
{
    public class MiddleOfLinkedListProblem
    {
        public ListNode Solve(ListNode head)
        {
            int nodeCounter = 0;
            Hashtable ht = new Hashtable();
            while (head != null)
            {
                ht.Add(nodeCounter, head);
                head = head.next;
                nodeCounter++;
            }
            return (ListNode)ht[ht.Count / 2];
        }
    }
}
