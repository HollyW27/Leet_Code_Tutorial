public class Solution 
{
    public bool LemonadeChange(int[] bills) 
    {
        int fiveCount = 0;
        int tenCount = 0;
        for(int i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                fiveCount++;
            }
            else if (bills[i] == 10)
            {
                tenCount++;
                if(fiveCount >= 1)
                {
                    fiveCount--;  
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(tenCount >= 1 && fiveCount >= 1)
                {
                    fiveCount--;
                    tenCount--;
                }
                else if(fiveCount >= 3)
                {
                    fiveCount = fiveCount - 3;
                }
                else
                {
                    return false;
                }
            }
            
        }
        return true;
    }
}