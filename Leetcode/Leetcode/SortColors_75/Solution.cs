using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SortColors_75
{
    internal class Solution
    {
        public void SortColors(int[] nums)
        {
            int zeros = nums.Count(s => s == 0);
            int ones = nums.Count(s => s == 1);
            int twos = nums.Count(s => s == 2);
            for (int i = 0; i < zeros; i++) { nums[i] = 0; }
            for (int i = zeros; i < zeros + ones; i++) { nums[i] = 1; }
            for (int i = zeros+ones;i< zeros + ones + twos; i++) { nums[i] = 2; }
        }
    }
}
