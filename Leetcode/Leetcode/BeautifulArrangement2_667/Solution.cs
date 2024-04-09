using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BeautifulArrangement2_667
{
    internal class Solution
    {
        public int[] ConstructArray(int n, int k)
        {
            List<int> ans = new List<int>();
            for (int i = 1; i < n-k+1; i++)
            {
                ans.Add(i);
            }
            while (k > 0)
            {
                if (ans.Contains(ans[ans.Count - 1] + k) || ans[ans.Count - 1] + k > n)
                {
                    ans.Add(ans[ans.Count - 1] - k);
                }
                else
                {
                    ans.Add(ans[ans.Count - 1] + k);
                }
                k--;
            }
            return ans.ToArray();
        }
    }
}
