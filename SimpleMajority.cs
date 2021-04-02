using System;
using System.Collections.Generic;
public class SimpleSolution
{
    // Boyer-Moore
    public int SimpleMajorityElement(int[] nums)
    {
        int count = 0;
        int? majority = null;
        foreach (var n in nums)
        {
            if (count == 0) majority = n;
            count += (n == majority) ? 1 : -1;
        }
        return Convert.ToInt32(majority);
    }
}