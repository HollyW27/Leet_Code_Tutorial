public class Solution 
{
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        int match = 0;
        int i = 0;
        if(ransomNote.Length > magazine.Length)
            return false;
        for(int j = 0; j < ransomNote.Length;)
        {
            if(ransomNote[j] == magazine[i])
                {
                    magazine = magazine.Remove(i , 1);
                    match++;
                    i = 0;
                    j++;
                    if(match == ransomNote.Length)
                    {
                        return true;
                    }
                }
            else if(i >= magazine.Length - 1)
                {
                    return false;
                }
            else if(ransomNote[j] != magazine[i])
                {
                    i++;
                }
        }
        return false;
    }
}