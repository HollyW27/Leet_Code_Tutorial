namespace FirstNumbertoAppearTwice;

public class Solution 
{
    public char RepeatedCharacter(string s) 
    {
        HashSet<char> letters = new HashSet<char>(){};
        for (int i = 0; i < s.Length; i++)
        {
            if (letters.Contains(s[i]))
            {
                return s[i];
            }
            letters.Add(s[i]);
        }
        //This should not be run
        throw new Exception();
    }
}