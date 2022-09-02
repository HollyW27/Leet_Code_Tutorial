public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
    Dictionary<int, int> piles = new Dictionary<int, int>();
    for(int i = 0; i < nums.Length; i++)
        {
        if (piles.ContainsKey(nums[i]))
            {
                piles[nums[i]] += 1;
            }
        else
            {
                piles.Add(nums[i], 1);   
            }
        }
    foreach(var pile in piles)
    {
     if(pile.Value > nums.Length/2)
     {
      return pile.Key;
     }
    }
    return 1;
    }

}