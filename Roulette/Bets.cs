using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public static class Bets
    {


        public static bool BetNumber(int bet, (string number, string color) ball)
        {
            if (bet != ReturnInt(ball)) return false;

            return true;
        }

        public static bool BetEvens((string number, string color) ball)
        {
            if (BetZeros(ball)) return false;

            return ReturnInt(ball) % 2 == 0;
        }
        public static bool BetOdds((string number, string color) ball)
        {
            if (BetZeros(ball)) return false;
            return ReturnInt(ball) % 2 != 0;
        }
        public static bool BetReds((string number, string color) ball) => ball.color == "red";
        public static bool BetBlacks((string number, string color) ball) => ball.color == "black";

        public static bool BetLows((string number, string color) ball)
        {
            if (BetZeros(ball)) return false;

            for (int i = 1; i <= 18; i++)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Bet0((string number, string color) ball) => ball.number == "0";

        private static bool Bet00((string number, string color) ball) => ball.number == "00";

        private static bool BetZeros((string number, string color) ball)
        {
            if (Bet0(ball) || Bet00(ball)) return true;

            return false;
        }



        public static bool BetHighs((string number, string color) ball)
        {
            if (ball.number == "0" || ball.number == "00") return false;

            for (int i = 19; i <= 36; i++)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Dozen1_12((string number, string color) ball)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool Dozen13_24((string number, string color) ball)
        {
            for (int i = 13; i <= 24; i++)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool Dozen25_36((string number, string color) ball)
        {
            for (int i = 25; i <= 36; i++)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ColumnOne((string number, string color) ball)
        {
            for (int i = 1; i <= 34; i += 3)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool ColumnTwo((string number, string color) ball)
        {
            for (int i = 2; i <= 35; i += 3)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool ColumnThree((string number, string color) ball)
        {
            for (int i = 3; i <= 36; i += 3)
            {
                if (ReturnInt(ball) == i)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Split((string number, string color) ball, params int[] nums)
        {

            if (nums[0] == ReturnInt(ball) || nums[1] == ReturnInt(ball)) return true;

            return false;
        }

        public static bool Corner((string number, string color) ball, params int[] nums)
        {

            if (nums[0] == ReturnInt(ball) || nums[1] == ReturnInt(ball) || nums[2] == ReturnInt(ball) || nums[3] == ReturnInt(ball))
            {
                return true;
            }

            return false;
        }

        public static bool Street((string number, string color) ball, params int[] nums)
        {
            if (nums[0] == ReturnInt(ball) || nums[1] == ReturnInt(ball) || nums[2] == ReturnInt(ball))
            {
                return true;
            }

            return false;
        }
        public static bool DoubleStreet((string number, string color) ball, params int[] nums)
        {
            if (Street(ball, nums[0], nums[1], nums[2]) || nums[3] == ReturnInt(ball) || nums[4] == ReturnInt(ball) || nums[5] == ReturnInt(ball))
            {
                return true;
            }

            return false;
        }

        private static int ReturnInt((string number, string color) ball)
        {
            return Int32.Parse(ball.number);
        }
    }
}
