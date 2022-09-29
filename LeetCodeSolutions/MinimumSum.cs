namespace MinimumSum;

public class Solution 
    {
        public int MinimumSum(int num) 
        {
            int newAns1 = 0;
            int[] numbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = num % 10;
                num = num / 10;
            }
            Array.Sort(numbers);
            newAns1 = numbers[0] + numbers[1];
            newAns1 = newAns1 * 10;
            newAns1 = newAns1 + numbers[2] + numbers[3];

            return newAns1;

        }
    }
