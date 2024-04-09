using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoSum_167
{
    internal class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int[] ans = new int[2];
            List<int> ints = numbers.ToList();
            while (i < ints.Count)
            {
                if (i >= 1 && ints[i] == ints[i - 1]) { i++;  }
                else
                {
                    int a = ints.IndexOf(ints[i]) + 1;
                    int diff = target - ints[i];
                    if (ints.Contains(diff))
                    {
                        ans[0] = a;
                        ans[1] = ints.IndexOf(diff) +i+ 2;
                        break;
                    }
                    else { i++; }
                }
            }
            return ans;
        }
        public int[] FindIndices(int[] numbers, int target)
        {
            int[] ans = new int[2];
            int i = 0;
            while (i < numbers.Length)
            {
                if (i >= 1 && numbers[i] == numbers[i - 1])
                {
                    i++;
                }
                else
                {
                    int a = Array.IndexOf(numbers, numbers[i]) + 1;
                    if (Array.Exists(numbers, x => x == target - numbers[i]))
                    {
                        int index = Array.FindIndex(numbers, i + 1, x => x == target - numbers[i]);
                        ans[0] = a;
                        ans[1] = index + i + 2;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return ans.ToArray();
        }

    }
}
