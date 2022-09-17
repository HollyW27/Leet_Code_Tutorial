namespace MissingNumber;
public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int i = 0;
        Array.Sort(nums);
        while(i == nums[i])
        {
            i++;
            if (i == nums.Length)
            {
                return i;
            }
        }
        return i;
    }
}