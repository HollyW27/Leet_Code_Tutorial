namespace HappyNumbers;

public class Solution
{
    public bool IsHappy(int n)
    {

        HashSet<int> PreviousNumb = new HashSet<int>();
        while (n != 1)
        {
            //Seperate numbers

            int[] intArray = new int[11];


            for (int i = 0; i < intArray.Length; i++)
            {

                intArray[i] = (n % 10);
                n = n / 10;
            }

            //Squaring
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = intArray[i] * intArray[i];
            }

            //Add Together
            int finalvalue = 0;
            foreach (int Adding in intArray)
            {
                finalvalue += Adding;
            }

            if (PreviousNumb.Contains(finalvalue))
            {
                return false;
            }

            PreviousNumb.Add(finalvalue);
            n = finalvalue;
        }


        return n == 1;
    }
}