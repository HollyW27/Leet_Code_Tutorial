public class Solution 
{
    public bool IsPowerOfFour(int n) 
    {
        int finalvalue = 0;
        HashSet<int> PowersOfFour = new HashSet<int>();    
        for (int i = 0; i <= 15 ; i++)
        {    
            finalvalue = (int)Math.Pow(4, i);
            PowersOfFour.Add(finalvalue);
        } 
    
        if (PowersOfFour.Contains(n))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }   
          
}