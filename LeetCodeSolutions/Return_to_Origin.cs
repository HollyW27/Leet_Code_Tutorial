namespace ReturntoOrigin;
public class Solution 
{
    public bool JudgeCircle(string moves) 
    {
        int vert = 0;
        int hori = 0;
        for (int i = 0; i < moves.Length; i++)
        {
            switch (moves[i])
            {
                case 'U':
                    vert++;
                    break;
                case 'D':
                    vert--;
                    break;
                case 'L':
                    hori--;
                    break;
                case 'R':
                    hori++;
                    break;
            }
        }
        if(vert == 0 && hori == 0)
        {
            return true;
        }
        return false;
    }
}