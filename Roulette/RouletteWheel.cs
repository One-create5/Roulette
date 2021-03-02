using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class RouletteWheel
    {
        private string[] numbers;
        private string[] color;
        private Random rand;
        public int Ball 
        {
            get;
            private set;
        }

        public RouletteWheel() 
        {
            numbers = GetNumbers(); 
            color = GetColors();
        }

        private string[] GetNumbers() 
        {
            string[] numbers = new string[38];

            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] =  (i + 1).ToString();
            }

            numbers[numbers.Length - 2] = "0";
            numbers[numbers.Length -1] = "00";

            return numbers;
        }
        private string[] GetColors() 
        {
            
            string red = "red";
            string black = "black";
            string green = "green";
            string[] color = 
                { red, black,red,
                  black,red,black,
                  red, black,red,
                  black,black,red,
                  black,red,black,
                  red, black,red,
                  red, black,red,
                  black,red,black,
                  red, black,red,
                  black,black,red,
                  black,red,black,
                  red, black,red,
                  green,green
                  };


            return color;
        }

        public void PrintBetTable() 
        {
            Console.WriteLine("\tRoulette Board");
            Console.Write("     ");
            PrintHorizontalLines(20);        
            Console.WriteLine($"     |{numbers[numbers.Length-2]} {color[color.Length-2]} | {numbers[numbers.Length-1]} {color[color.Length -1]}|");
            PrintHorizontalLines(32);
            for (int i = 0; i < 36; i+=3)
            {
                Console.WriteLine(String.Format("|{0,-2} {1,-5} | {2,-2} {3,-5} | {4,-2} {5,-5}|",numbers[i], color[i], numbers[i + 1], color[i + 1], numbers[i + 2], color[i + 2]));
                PrintHorizontalLines(32);
            }
        }


        private void PrintHorizontalLines(int number) 
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public (string number, string color) SpinWheel() 
        {
            rand = new Random();
            Ball = rand.Next(1,39);

            string _00 = "00";
            string _0 = "0";
            string colorIs = color[Ball - 1];

            if (Ball == 37)
            {
                return (_0, colorIs);
            }
            else if (Ball == 38)
            {
                return (_00, colorIs);
            }
      
            return (Ball.ToString(), colorIs);
        }

        
        private void PrintNumbers() 
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }

        private void PrintColors() 
        {
            foreach (var item in color)
            {
                Console.Write($"{item} ");
            }
        }

    }
}
