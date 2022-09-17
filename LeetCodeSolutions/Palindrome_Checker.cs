namespace PalindromeChecker;
public class Solution {
         public static bool isAlphaNumeric(char c)
            {
                return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
            }

            public bool IsPalindrome(string s){
                s = s.ToLower();
                s = String.Concat(Array.FindAll(s.ToCharArray(), isAlphaNumeric));
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                String b = new String (charArray);

                if (s == b)
                { return true; }
                else { return false; }
         
        
        
    }
}