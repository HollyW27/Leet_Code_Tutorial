namespace SecondHighestDigit;

public class Solution
{
    public int SecondHighest(string s)
    {
        int highest = int.MinValue;
        int second = int.MinValue;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                if (s[i] > highest)
                {
                    second = highest;
                    highest = s[i];
                }
                else if (s[i] > second && s[i] != highest)
                {
                    second = s[i];
                }
            }
        }

        if (second < -1)
        {
            return -1;
        }

        return (int)second - 48;
    }
}