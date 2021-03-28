using System;
using System.Collections.Generic;

public class Solution
{
    Dictionary<string, int> mapped = new Dictionary<string, int>(){
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000}
    };

    public int RomanToInt(string s)
    {
        int total = 0;
        int j = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            j = i + 1 >= s.Length ? i : i + 1;
            var result = mapped.TryGetValue(s[i].ToString(), out int v1);
            result = mapped.TryGetValue(s[j].ToString(), out int v2);
            if (result)
            {
                if (v1 >= v2) total += v1;
                else total -= v1;
            }
        }
        return total;
    }
}