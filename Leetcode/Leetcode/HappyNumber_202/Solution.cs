using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.HappyNumber_202
{
    internal class Solution
    {
        public bool IsHappy(int n)
        {
            List<int> result = new List<int>();
            result.Add(n);
            while (result[result.Count - 1] != 1)
            {
                string nStr = result[result.Count-1].ToString();
                int a = 0;
                for (int i = 0; i < nStr.Length; i++) { a += Convert.ToInt32(nStr[i].ToString()) * Convert.ToInt32(nStr[i].ToString()); }
                if (result.Contains(a)) { return false; }
                else { result.Add(a); }
            }
            return true;
        }
    }
}
