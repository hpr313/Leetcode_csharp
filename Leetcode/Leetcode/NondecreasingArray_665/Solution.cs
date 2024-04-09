using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.NondecreasingArray_665
{
    internal class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            int change = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    change++;
                    if (i == 1 | nums[i] >= nums[i - 2]) { nums[i - 1] = nums[i]; }
                    else { nums[i] = nums[i - 1]; }
                }
                
            }
            return change <= 1;
        }
    }
}
