using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaangProblems._412_FizzBuzz
{
    public class FizzBuzzProblem
    {
        public string[] Solve(int n)
        {
            string[] result = new string[n];
            for (int i = 1; i < n+1; i++)
            {
                bool div3 = i % 3 == 0;
                bool div5 = i % 5 == 0;
                string tempResult = null;
                if(div3 && div5){
                    tempResult = "FizzBuzz";
                }
                else if (div3)
                {
                    tempResult = "Fizz";
                }
                else if (div5)
                {
                    tempResult = "Buzz";
                }
                else
                {
                    tempResult = i.ToString();
                }
                result[i-1] = tempResult;
            }
            return result;
        }
    }
}
