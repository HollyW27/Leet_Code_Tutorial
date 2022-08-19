public class Solution 
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int exchangable = int.MaxValue;
        int maxDrank = numBottles;
        while(exchangable >= numExchange)
        {
            int remainder = (numBottles%numExchange);
            numBottles = numBottles / numExchange;
            maxDrank += numBottles;
            exchangable = numBottles + remainder;
            numBottles = exchangable;     
        }
        return maxDrank;
    }
}