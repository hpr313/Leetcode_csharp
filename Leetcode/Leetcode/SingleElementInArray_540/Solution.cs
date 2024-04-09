using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SingleElementInArray_540
{
    internal class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int i = 0;
            while (i < nums.Length - 1) { 
                if (nums[i] != nums[i + 1] ) { return nums[i]; }
                else { i+=2; }
            }
            return nums[nums.Length - 1];

        }
    }
}
