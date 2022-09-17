namespace HeightChecker;
public class Solution {
    public int HeightChecker(int[] heights) 
    {
    int[] expected = new int[heights.Length];
        for (int i = 0; i < heights.Length; i++)
        {
        expected[i] = heights[i];
        }
    Array.Sort(expected);
    int counter = 0;    
        for (int i = 0; i < expected.Length; i++)
        {
         if (expected [i] != heights [i])
         { 
             counter++;
         }
        }
       return counter;
    }
}