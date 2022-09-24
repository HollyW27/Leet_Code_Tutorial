namespace MinMoves;

public class Solution 
    {
        public int MinimumMoves(string s) 
        {
            int moves = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'X')
                {
                    moves++;
                    i = i + 2;
                }
            }
            return moves;
        }
    }