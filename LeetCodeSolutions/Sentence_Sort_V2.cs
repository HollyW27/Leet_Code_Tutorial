namespace SentenceSortV2;
public class Solution 
{
    public string SortSentence(string s) 
    {
        string completed ="";
        string[] words = s.Split(" ");
        string[] sentence = new string[words.Length];
        for(int i = 0; i < words.Length; i++)
            {
                char[] position = words[i].ToCharArray();
                char temp1 = position[position.Length - 1];
                string temp2 = temp1.ToString();
                int order = int.Parse(temp2);
                words[i] = words[i].Remove(words[i].Length - 1, 1);
                sentence[order - 1] = words[i];
                if (words.Length - 1 == i)
                {
                    for(int j = 0; j < sentence.Length; j++)
                    {
                       completed += sentence[j] + " "; 
                    }
                }
            }
            completed = completed.TrimEnd();
            return completed;
            }
}   
