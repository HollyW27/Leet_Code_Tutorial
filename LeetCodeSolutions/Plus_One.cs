namespace PlusOne;
public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        int i = digits.Length - 1;

        while(digits[i] == 9)
            {
                digits[i] = 0;
                if(i == 0)
                {
                    int[] digitsLong = new int[digits.Length + 1];
                    digitsLong[0] = 1;
                    return digitsLong;
                }
                i--;
            }
        digits[i] = digits[i] + 1;  
        return digits;
    }
}