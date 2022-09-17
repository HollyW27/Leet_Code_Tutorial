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
            int? previous = null;
            int counter = 0; 
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
                return (int)previous;  
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