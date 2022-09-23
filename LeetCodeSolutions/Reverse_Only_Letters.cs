namespace ReverseOnlyLetters;

public class Solution 
{
    public string ReverseOnlyLetters(string s) 
    {
        StringBuilder modified = new StringBuilder(s);
        int j = s.Length - 1;
        int i = 0;
        while(i < j)
        {
            if (!Char.IsLower(modified[i]) && !Char.IsUpper(modified[i]))
            {
                i++;
            }
            else if (!Char.IsLower(modified[j]) && !Char.IsUpper(modified[j]))
            {
                j--;
            }
            else
            {
                modified[i] = modified[j];
                modified[j] = s[i];
                j--;
                i++;
            }
        }
        string a = modified.ToString();
        return a;
    }
}