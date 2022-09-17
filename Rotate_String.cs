public class Solution 
{
    public bool RotateString(string s, string goal) 
    {
        if(s.Length != goal.Length)
        {
            return false;
        }
        int j = 0;
        int k = 0;
        //Increments the goal string
        for(int i = 0; i < goal.Length; i++)
        {
            //Checks if the goal char matches the s char
            if(goal[i] == s[0])
            {
                //sets the matched letter to the starting point for checking letters
                k = i;
                while(goal[k] == s[j])
                {
                    if(j == s.Length - 1)
                    {
                        return true;
                    }
                    k++;    
                    j++;
                    if(k == goal.Length)
                    {
                        k = 0;
                    }
                }
                j = 0;
            }
        }
        
    return false;
    }
}