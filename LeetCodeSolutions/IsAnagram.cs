namespace IsAnagram;

public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        //Checks that the two strings are of equal length
        if (s.Length != t.Length)
        {
            return false;
        }
        List<char> used = new List<char>();
        
        //Counts all of the letters in both strings and see if they are the same
        for(int i = 0; i < s.Length; i++)
        {
            if (used.Contains(s[i]))
            {
                continue;
            }
            int sCount = s.Count(f => (f == s[i]));
            int tCount = t.Count(f => (f == s[i]));
            if(sCount != tCount)
            {
                return false;
            }
            used.Add(s[i]);
        }
        return true;
    }
}