namespace MaxProfit;
public class Solution
{
    public int MaxProfit(int[] prices) 
    {
        int lowest = prices[0];
        int best = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < lowest)
            {
                lowest = prices[i];
            }
            else 
            {
            int difference = prices[i] - lowest;
            if(difference > best)
            {
                best = difference;
            }
            }
        }
        return best;
    }
}