using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace MaangProblems._0020_ValidParentheses
{
    public class ValidParenthesesProblem
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (s.Length % 2 != 0) return false;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    if (stack.Count == 0)
                        return false;
                    char top = stack.Pop();
                    if (c == ')' && top != '(') return false;
                    if (c == '}' && top != '{') return false;
                    if (c == ']' && top != '[') return false;
                }
            }
            return stack.Count == 0;
        }
    }
}