using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaangProblems._1672_MaximumWealth
{
    public class MaximumWealthProblem
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                    sum += accounts[i][j];
                max = sum > max ? sum : max;
            }
            return max;
        }
    }
}
