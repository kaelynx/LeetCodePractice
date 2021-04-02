using System;
using System.Collections.Generic;
public class Solution
{
    // Boyer-Moore
    // majority = at most 1 when n/2, at most 2 when n/3, at most 3 when n/4, etc.
    public IList<int> MajorityElement(int[] nums)
    {
        IList<int> result = new List<int>();
        int n = nums.Length;
        int count1 = 0;
        int count2 = 0;
        int? majority1 = null;
        int? majority2 = null;

        foreach (var num in nums)
        {
            // already found first candidate
            if (majority1 != null && num == majority1) ++count1;
            // already found second candidate
            else if (majority2 != null && num == majority2) ++count2;
            else if (count1 == 0)
            {
                majority1 = num;
                ++count1;
            }
            else if (count2 == 0)
            {
                majority2 = num;
                ++count2;
            }
            else
            {
                // if num is different than both candidates, decrement both
                --count1;
                --count2;
            }
        }
        /*
        * need second loop because
        * majority1 and majority2 already found, but could be invalid
        * ex. length = 6, n / 3 = 2, [2,2,2,2,1,1]
        * majority1 = 2, majority2 = 1, count1 = 3, count2 = 1
        * 1 < 2 = invalid option
        */
        count1 = 0;
        count2 = 0;

        foreach (var num in nums)
        {
            if (majority1 != null && majority1 == num) ++count1;
            if (majority2 != null && majority2 == num) ++count2;
        }

        if (count1 > n / 3) result.Add(Convert.ToInt32(majority1));
        if (count2 > n / 3) result.Add(Convert.ToInt32(majority2));
        return result;
    }
}