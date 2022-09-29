namespace RectangleOverlap;

public class Solution 
{
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) 
    { 
        bool checkX = false;
        bool checkY = false;
        if(rec1[2] > rec2[0])
        {
            if(rec1[0] < rec2[2])
            {
                checkX = true;
            }
        }
        if(rec1[3] > rec2[1])
        {
            if(rec1[1] < rec2[3])
            {
                checkY = true;
            }
        }
        return checkX && checkY;
    }
}