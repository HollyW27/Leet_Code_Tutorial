namespace MoveZeros;
public class Solution 
{
    public void MoveZeroes(int[] nums)
    {
        int firstZero = 0;
        int counter = 0;
        int numberCounter = 0;
        //Checks if the int in the int[] is a 0 or not
        for (int i = 0; i < nums.Length; i++)
        {
            //Finds where the first 0 is so that we can put all of the numbers after it into it
            if (nums[i] == 0 && counter < 1)
            {
                firstZero = nums[i];
                counter++;
            }
            else if (nums[i] == 0)
            {
                continue;
            }
            //Puts the number into the first position that doesn't have another number and sets it's previous location to zero if moved
            else
            {
                if (nums[firstZero + numberCounter] == nums[i])
                {
                    numberCounter++;
                    continue;
                }
                nums[firstZero + numberCounter] = nums[i];
                nums[i] = 0;
                numberCounter++;
            }
        }
    }
}