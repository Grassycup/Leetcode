// Reverse digits of an integer.

// Example1: x = 123, return 321
// Example2: x = -123, return -321

// click to show spoilers.

// Note:
// The input is assumed to be a 32-bit signed integer. Your function should return 0 when the reversed integer overflows.
public class Solution {
    public int Reverse(int x) {
        int y;
        try {
            string xStr = x.ToString();
            string revXStr = "";
            int neg = 1;
            for (int i = xStr.Length - 1; i >= 0; i--) {
                if (i == 0 && xStr[i] == '-') {
                    neg = -1;
                    continue;
                }
                revXStr += xStr[i];
            }
            y = Convert.ToInt32(revXStr);
            y *= neg;
            return y;
        } catch (Exception e) {
            return 0;
        }
    }
}