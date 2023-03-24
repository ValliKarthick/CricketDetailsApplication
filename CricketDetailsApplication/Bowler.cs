namespace CricketDetailsApplication
{
    public class Bowler :Player
    {
        public int oversBowled, wicketsTaken;
        public double runsConceded;

        public void setRunsGiven(int runsGiven)
        {
            runsConceded = runsGiven;
        }
        public void setWickets(int WicketsTaken)
        {
            this.wicketsTaken = WicketsTaken;
        }
        public double CalculatebBowlingAverage()
        {
            if (wicketsTaken == 0)
            {
                return 0;
            }

            return ((double)runsConceded / wicketsTaken);
        }
    }
}
