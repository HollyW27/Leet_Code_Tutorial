namespace LastWordLength;
public class Solution {
    public int LengthOfLastWord(string s) {

        s = s.Trim();
        string[] words = s.Split(" ");
        string seperated = words[words.Length-1];
        return seperated.Length;   
    }
        
    
}