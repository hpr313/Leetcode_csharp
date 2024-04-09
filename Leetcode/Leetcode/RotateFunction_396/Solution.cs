using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.RotateFunction_396
{
    internal class Solution
    {
        public int MaxRotateFunction(int[] nums)
        {
            if (nums.Length == 0) return 0;
            else
            {
                int initial = 0;
                for (int j = 0; j < nums.Length; j++) { initial += j * nums[j]; }
                int maxValue = initial;
                int i = 1;
                
                while (i < nums.Length)
                {
                    int weight = 0;
                    weight = initial + nums.Sum() - nums.Length * nums[nums.Length - i];
                    initial = weight;
                    if (weight > maxValue) { maxValue = weight;}
                    i++;
                }
                return maxValue;
            }
        }
    }
}
