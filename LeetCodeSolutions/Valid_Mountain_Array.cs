namespace ValidMountainArray;

public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3)
        {
            return false;
        }

        bool goneUp = false;
        bool goneDown = false;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                return false;
            }

            if (arr[i] < arr[i + 1] && goneDown == true)
            {
                return false;
            }

            if (arr[i] > arr[i + 1] && goneUp == true)
            {
                goneDown = true;
            }

            if (arr[i] < arr[i + 1])
            {
                goneUp = true;
            }

            if (arr[i] > arr[i + 1] && goneUp != true)
            {
                return false;
            }
        }

        return goneUp && goneDown;
    }
}