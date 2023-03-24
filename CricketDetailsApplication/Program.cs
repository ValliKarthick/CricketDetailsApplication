using System;

namespace CricketDetailsApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Batsman batsman = new Batsman();
            batsman.name = "Kohli";
            batsman.age = 30;
            batsman.setOvers(8);
            batsman.setRunsScored(78);
            double runRate = batsman.CalculateRunRate();
            Console.WriteLine(batsman.name + "-" + batsman.age + "-" + runRate);            

            Bowler bowler = new Bowler();
            bowler.name = "Bumrah";
            bowler.age = 25;
            bowler.runsConceded =50;
            bowler.wicketsTaken = 3;
            bowler.CalculatebBowlingAverage();
            Console.WriteLine(bowler.name + "-" + bowler.age + "-" + bowler.CalculatebBowlingAverage()) ;

            Console.ReadLine();
        }
    }
}
