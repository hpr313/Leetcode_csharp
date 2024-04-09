using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._739_DailyTemperatures
{
    internal class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int maxValue = temperatures.Max();
            int[] ans = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length - 1; i++)
            {
                if (temperatures[i] == maxValue) { ans[i] = 0; }
                else
                {
                    int j = i + 1;
                    while (j < temperatures.Length)
                    {
                        if (temperatures[i] < temperatures[j])
                        {
                            ans[i] = j - i;
                            break;
                        }
                        else { j++; }
                    }
                }
            }
            ans[ans.Length - 1] = 0;
            return ans;
        }
    }
}
