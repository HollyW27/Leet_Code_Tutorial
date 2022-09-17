public class Solution 
{
    public int TimeRequiredToBuy(int[] tickets, int k) 
    {
        //Sets up the value to compare the array to
        int compare = tickets[k];
        int total = 0;
        int i = 0;
        
        //Checks if every int in tickets is >= to compare or smaller and adds the correct number
        while(i < tickets.Length)
        {
            if (i > k && tickets[i] >= compare)
            {
                total += compare - 1;
            }
            
            else if (tickets[i] >= compare)
            {
                total += compare;
            }
            
            else
            {
                total += tickets[i];
            }
           Console.WriteLine(total);
            i++;
        }
        
        return total;
    }
}