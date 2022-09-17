namespace CanPlaceFlowers;
public class Solution 
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
    int counter = 1;
    int plantable = 0;
    if(flowerbed.Length == 1)
    {
        if(flowerbed[0] == 1 && n > 0 && flowerbed.Length == 1)
        return false;
        
        else
        plantable++;
    }
        
    for(int i = 0; i < flowerbed.Length - 1; i++)
    {
        if (flowerbed[i] == 0)
            counter++;   
        if(flowerbed[i] == 1 || flowerbed[i+1] == 1)
            counter = 0;
        if (counter == 1 && flowerbed[i+1] == 0 && i == flowerbed.Length - 2)
            plantable++;
        if (counter == 2)
        {
            plantable++;
            counter = 0;
        }
    }
    if (n <= plantable)
        return true;
        
    else
        return false;
    }
}