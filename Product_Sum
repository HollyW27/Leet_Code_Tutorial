public class Solution {
    public int SubtractProductAndSum(int n) 
    {
        int product = 1;
        int sum = 0;
        double length = Math.Log10((n) + 1);
        for (int i = 0; i < length; i++)
        {
            int number = n%10;
            product *= number;
            sum += number;
            n /= 10;
        }
        return product-sum;
    
    }
}