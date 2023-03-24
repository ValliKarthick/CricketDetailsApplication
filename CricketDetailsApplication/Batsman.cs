namespace CricketDetailsApplication
{
    public class Batsman : Player, IRunRateCalculator
    {
        public int runsScored;
        public double oversPlayed;
        public void setRunsScored(int runsTaken)
        {
            runsScored = runsTaken;
        }
        public void setOvers(int oversPlayed)
        {
            this.oversPlayed = oversPlayed;
        }
        public double CalculateRunRate()
        {
            if (oversPlayed == 0)
            {
                return 0;
            }

            return ((double)runsScored / oversPlayed);
        }
    }
}
