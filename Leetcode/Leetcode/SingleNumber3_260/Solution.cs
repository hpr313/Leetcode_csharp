using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SingleNumber3_260
{
    internal class Solution
    {
        public int[] SingleNumber(int[] nums)
        {
            List<int> ans = new List<int>();
            if (nums.Length == 2 ) { return nums; }
            else
            {
                List<int> newNums = nums.ToList();
                while (ans.Count < 2)
                {
                    int a = newNums[0];
                    if (newNums.Count(s => s == a) == 2)
                    {
                        newNums.Remove(a);
                        newNums.Remove(a);
                    }
                    else
                    {
                        ans.Add(a);
                        newNums.Remove(a );
                    }
                    if (ans.Count == 2 ) { break; }
                }
                return ans.ToArray();
            }
        }
    }
}
