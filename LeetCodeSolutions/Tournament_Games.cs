namespace TournamentGames;
public class Solution 
{
    public int NumberOfMatches(int n) 
    {
        int teamsLeft = n % 2;
        int totalGames = 0;
        while (n > 1)
        {
            totalGames += n/2;
            n = n/2 + teamsLeft;
            teamsLeft = n % 2;     
        }
        return totalGames;
    }
}