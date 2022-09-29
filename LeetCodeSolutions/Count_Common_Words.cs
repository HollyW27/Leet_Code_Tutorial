namespace CountCommonWords;

public class Solution 
{
    int answer = 0;
    int words1Count = 0;
    int words2Count = 0;
    public int CountWords(string[] words1, string[] words2) 
    {
        for(int i = 0; i < words1.Length; i++)
        {
            words1Count = words1.Count(x => (x == words1[i]));
            if(words1Count == 1)
            {
                words2Count = words2.Count(x => (x == words1[i]));
                if(words2Count == 1)
                {
                    answer += 1;
                }
            }
        }
        return answer;
    }
}