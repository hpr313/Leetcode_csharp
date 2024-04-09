using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SumOfSquareNumbers_633
{
    internal class Solution
    {
        public bool JudgeSquareSum(int c)
        {
            if (c <= 2) { return true; }
            else
            {
                int i = 0;
                while (i < Math.Sqrt(c-i))
                {
                    double sq = Math.Sqrt(c - i * i);
                    int remainder = (int)Math.Floor(sq);
                    if (i * i + remainder * remainder == c) { return true; }
                    else { i++; }
                }
                return false;
            }
        }
    }
}
