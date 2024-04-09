using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CountPrimes_204
{
    internal class Solution
    {
        public int CountPrimes(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int ans = 1;
            if (n <= 2) { return 0; }
            else
            {
                for (int i = 3;  i < n; i+=2) {
                    int j = 0;
                    while (j < primes.Count)
                    {
                        if (i % primes[j] == 0) { break; }
                        else { j++; }
                        if (j == primes.Count) {
                            primes.Add(i);
                            ans++; 
                            break; }
                    }
                }
                return primes.Count;
            }
        }
    }
}
