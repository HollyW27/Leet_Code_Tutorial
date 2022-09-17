  public class Solution { 
    public int FindPoisonedDuration(int[] timeSeries, int duration) {  int TotalDuration = 0;
        //foreach(int i in timeSeries)
        for(int i = 0; i < timeSeries.Length - 1; i++)
        {
            if (timeSeries[i+1] < timeSeries[i] + duration)
            {
                TotalDuration += timeSeries[i+1] - timeSeries[i];
            }
            else
                 TotalDuration += duration;
        }
        TotalDuration += duration;
          return TotalDuration;                                                           
        } 
    }
