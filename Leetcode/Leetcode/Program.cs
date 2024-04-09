using Leetcode.SumOfSquareNumbers_633;
using System;

namespace Leetcode // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.JudgeSquareSum(3).ToString());
            //int[] numbers = { 0,0,2, 7, 11, 15 };
            //int[] ans = s.TwoSum(numbers, 22);
            //for (int i = 0; i< ans.Length; i++) { Console.WriteLine(ans[i].ToString()); }
            //Console.WriteLine(s.TwoSum(numbers,9).ToString());
        }
    }
}