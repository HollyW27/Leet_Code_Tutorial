public class Solution 
{
    public string SortSentence(string s) 
    {
              string[] digits = new string[10]{"1","2","3","4","5","6","7","8","9","10"};  
      string[] words = s.Split(" ");
        string sentence = "";
        int j = 0;
        for (int i = 0; words.Length > i; i++)
        {
            if (words[i].Contains(digits[j]))
            {
                words[i] = words[i].Remove(words[i].Length - 1, 1);
                sentence += words[i] + " ";
                j++;
                i = -1;
            }
                
        }
        sentence = sentence.Remove(sentence.Length - 1, 1);
        return sentence;
    }
         
    
}