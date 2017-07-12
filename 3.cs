// Given a string, find the length of the longest substring without repeating characters.

// Examples:

// Given "abcabcbb", the answer is "abc", which the length is 3.

// Given "bbbbb", the answer is "b", with the length of 1.

// Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null || s.Length == 0) {
            return 0;
        }
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int max = 0;
        int last = -1;
        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            int index;
            bool found = charIndex.TryGetValue(c, out index);
            if(found)
                last = last > index ? last : index;
            charIndex[c] = i;
            int currCount = i - last;
            max = max > currCount ? max : currCount;
        }
        return max;
    }
}