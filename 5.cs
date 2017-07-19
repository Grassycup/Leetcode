public class Solution {
    public string LongestPalindrome(string s) {
        if (String.IsNullOrEmpty(s)) {
            return "";
        }
        string answer = "";
        bool[,] results = new bool[s.Length, s.Length];
        int start = 0;
        int length = 1;
        // take care of base case
        for (int i = 0; i < s.Length; i++) {
            results[i, i] = true;
            if (i + 1 < s.Length && s[i] == s[i + 1]) {
                results[i, i + 1] = true;
                start = i;
                length = 2;
            }
        }

        // since substring of length 2 has already been calculated, start with 3
        for (int k = 3; k <= s.Length; k++) {
            // offset by min length
            for (int i = 0; i < s.Length - k + 1; i++) {
                // last index of the substring
                int j = i + k - 1;

                // if smaller substring within this current substring is a palindrome, we just have to compare the outermost
                if (results[i + 1, j - 1] && s[i] == s[j]) {
                    results[i, j] = true;
                    // if current length is greater than previous biggest, update
                    if (k > length) {
                        start = i;
                        length = k;
                    }
                }
            }
        }
        return s.Substring(start, length);
    }
}
