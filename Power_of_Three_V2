public class Solution 
{
    public int ThirdMax(int[] nums) 
    {
    //Checks if there is more than 3 numbers
       if (nums.Length > 2)
       {
    //Ordering Array into decending order
            Array.Sort(nums);
            Array.Reverse(nums);
            int previous = 0;
            int counter = 0;
           if(nums[0]== 0) 
           {
             counter++;
            }
           for (int i = 0 ; i < nums.Length; i++)
            {

                if(nums[i]==previous)
                {
                    previous = nums[i];
                }   
                else
                {   
                    previous = nums[i];
                    counter++;
                }
                    
                if(counter == 3)
               {
                return previous;  
               }
               
                
            } 
            return nums[0];
       }
        else
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums[0];
        }


    }
}