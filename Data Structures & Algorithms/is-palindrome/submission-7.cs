public class Solution {
    public bool IsPalindrome(string s) {
        s = s.TrimEnd('?', '!', '.');
        s = s.ToLower();
        s = s.Replace(" ", "");
        s = s.Replace(",", "");
        s = s.Replace("'", "");
             s = s.Replace(".", "");
              s = s.Replace(":", "");
        Console.WriteLine(s.Length);
        for (int i = 0; i < s.Length; i++) {
            for (int j = s.Length - 1 - i; j != 0; j--) {
                Console.WriteLine(s[i] + ", " + s[j]);
                if (s[i] == s[j]) {
                    break;
                } else {
                    return false;
                }
            }
        }
        return true;
    }
}
