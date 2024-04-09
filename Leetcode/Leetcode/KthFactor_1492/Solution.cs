using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.KthFactor_1492
{
    internal class Solution
    {
        public int KthFactor(int n, int k)
        {
            List<int> factors = findFactors(n);
            if (k > factors.Count) { return -1; }
            else if (k == 1) { return 1; }
            else { return factors[k-1]; }
        }

        public List<int> findFactors(int n)
        {
            List<int> factors = new List<int>();
            factors.Add(1);
            var a = Math.Ceiling(Math.Sqrt(n));
            for (int i = 2; i <= a; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    if (i != n / i)
                    {
                        factors.Add(n/i);
                    }
                }
            }
            factors.Add(n);
            List<int> noDuplicate = new List<int>();
            noDuplicate = factors.Distinct().ToList();
            noDuplicate.Sort();
            return noDuplicate;
        }
    }
}
