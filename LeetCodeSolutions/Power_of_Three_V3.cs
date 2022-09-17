namespace PowerofThreeV3;
public class Solution 
{
    public int ThirdMax(int[] nums) 
    {
    int[] top3 = new int[3];
    int visited = 0;
    bool HasMinValue = false;    
    for (int i = 0; i < top3.Length; i++)
    {
        top3[i] = int.MinValue;
    }
        foreach(int i in nums)
        {
            if(i == top3[0] || i == top3[1] || i == top3[2])
            {
                if(i == int.MinValue && HasMinValue == false)
                
                {
                    visited++;
                    HasMinValue = true;
                }
                continue;   
            }
            
            if (i > top3[0])
            {
                top3[2] = top3[1];
                top3[1] = top3[0];
                top3[0] = i;
                visited++;       
            }
            
            else if(i > top3[1])
            {
                top3[2] = top3[1];
                top3[1] = i;
                visited++;
            }
            else if(i > top3[2])
            {
                top3[2] = i;
                visited++;
            }
        }
        if (visited > 2)
        {
            return top3[2];
        }
        else
        {
            return top3[0];
        }
        
            
    }
}