public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var temp = 0;
        for(int i = 0; i < s.Length; ++i){
            bool [] prev = new bool[256];
            for(int j = i; j < s.Length; ++j){
                if(prev[s[j]] == true) break;
                else {
                    temp = (j - i + 1) > temp ? (j - i + 1) : temp;
                    prev[s[j]] = true;
                }  
            }
        }
        return temp;
    }
}