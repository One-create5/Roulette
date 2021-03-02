using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            RouletteWheel rouletteWheel = new RouletteWheel();
            rouletteWheel.PrintBetTable();
            (string number, string color) ball = rouletteWheel.SpinWheel();

            Console.WriteLine($"Ball Landed on\t: {ball}");
            Console.WriteLine($"Winning bets!");
            DisplatResults(ball);

        }

        public static void DisplatResults((string number, string color) ball) 
        {
            int numberbet = 30;
            int[] street = {22,23,24};
            int[] doubleSt = {1,2,3,4,5,6};
            int[] split = { 26, 29 };
            int[] corner = { 26,27,29,30};

            bool BetOn30 = Bets.BetNumber(numberbet, ball);
            bool betOnEvens = Bets.BetEvens(ball);
            bool betOnOdds = Bets.BetOdds(ball);
            bool betOnReds = Bets.BetReds(ball);
            bool betOnBlacks = Bets.BetBlacks(ball);
            bool betOnLows = Bets.BetLows(ball);
            bool betOnHighs = Bets.BetHighs(ball);
            bool betOnDozen_1_12 = Bets.Dozen1_12(ball);
            bool betOnDozen_13_24 = Bets.Dozen13_24(ball);
            bool betOnDozen_25_36 = Bets.Dozen25_36(ball);
            bool betOnFirstCol = Bets.ColumnOne(ball);
            bool betOnSecondCol = Bets.ColumnTwo(ball);
            bool betOnThirdCol = Bets.ColumnThree(ball);
            bool betOnStreet = Bets.Street(ball,street);
            bool betOnDoubleSt = Bets.DoubleStreet(ball,doubleSt);
            bool betOnSplit = Bets.Split(ball,split);
            bool betOnCorner = Bets.Corner(ball,corner);

            if (BetOn30)
            {
                Console.WriteLine($"Number {numberbet} bet won!");
            }
            if (betOnEvens)
            {
                Console.WriteLine("Bet on evens won!");
            }
            if (betOnOdds)
            {
                Console.WriteLine("Bet on odds won!");
            }
            if (betOnReds)
            {
                Console.WriteLine("Bet on reds won!");
            }
            if (betOnBlacks)
            {
                Console.WriteLine("Bet on blacks won!");
            }
            if (betOnLows)
            {
                Console.WriteLine("Bet on lows won!");
            }
            if (betOnHighs)
            {
                Console.WriteLine("Bet on highs won!");
            }
            if (betOnDozen_1_12)
            {
                Console.WriteLine("Bet on dozen (1ST 12) won!");
            }
            if (betOnDozen_13_24)
            {
                Console.WriteLine("Bet on dozen (2ND 12) won!");
            }
            if (betOnDozen_25_36)
            {
                Console.WriteLine("Bet on dozen (3RD 12) won!");
            }
            if (betOnFirstCol)
            {
                Console.WriteLine("Bet on 1ST column won!");
            }
            if (betOnSecondCol)
            {
                Console.WriteLine("Bet on 2ND column won!");
            }
            if (betOnThirdCol)
            {
                Console.WriteLine("Bet on 3RD column won!");
            }
            if (betOnStreet)
            {
                Console.WriteLine($"Bet on street {street[0]},{street[1]},{street[2]} won!");
            }
            if (betOnDoubleSt)
            {
                Console.WriteLine($"Bet on double street {doubleSt[0]},{doubleSt[1]},{doubleSt[2]},{doubleSt[3]},{doubleSt[4]},{doubleSt[5]} won!");
            }
            if (betOnSplit)
            {
                Console.WriteLine($"Bet on street {split[0]},{split[1]} won!");
            }
            if (betOnCorner)
            {
                Console.WriteLine($"Bet on corner {corner[0]},{corner[1]},{corner[2]},{corner[3]} won!");
            }
        }
    }
}
