using System.Collections.Generic;

namespace MaangProblems._2011_FinalValueAfterOperations
{
    public class FinalValueAfterOperationsProblem
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "--X" || operations[i] == "X--")
                    result--;
                if (operations[i] == "++X" || operations[i] == "X++")
                    result++;
            }
            return result;
        }
    }
}