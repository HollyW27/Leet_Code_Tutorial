public class Solution 
{
    public int RomanToInt(string s) 
    {
    int total = 0; 
    //Assigning values to the roman numerals
    Dictionary<char, int> values = new Dictionary<char, int>();
    values.Add('I', 1);
    values.Add('V', 5);
    values.Add('X', 10);
    values.Add('L', 50);
    values.Add('C', 100);
    values.Add('D', 500);
    values.Add('M', 1000);
    
    //Reverses the string via a charArray
    char[] reverse = s.ToCharArray(); 
    Array.Reverse(reverse);
    string reversedString = String.Concat(reverse);
    
    //Converting string to value then adding it    
    for(int i = 0; i < s.Length; i++)
    {
        total += values[reversedString[i]];
        if(i+1 < s.Length && values[reversedString[i+1]] < values[reversedString[i]])
        {
            total -= values[reversedString[i+1]];
            i++;
        }
    }
    
        return total;
    }
}