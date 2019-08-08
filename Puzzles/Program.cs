using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray(); 
            // TossCoin();
            // System.Console.WriteLine("Coin Toss: " + TossCoin());
            // TossMultipleCoins(10);
            Names();
        }

        // Random Array
        public static int[] RandomArray()
        {
            int[] randomArray = new int[10];
            int sum = 0;
            Random rand = new Random();
            for(var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = (rand.Next(5, 25));
                System.Console.WriteLine("randomArray[i] = " + randomArray[i]);
            }
            int min = randomArray[0];
            int max = randomArray[0];

            for(int i = 0; i < randomArray.Length; i++)
            {
                if(min > randomArray[i]){
                    min = randomArray[i];
                }
                if(max < randomArray[i]){
                    max = randomArray[i];
                }
                sum += randomArray[i];
            }
            Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}", min, max, sum);
            return randomArray;
        }

        // Coin Flip
        public static string TossCoin()
        {
            string result = "heads";
            Random rand = new Random();
            int coin = rand.Next(10);
            if(coin % 2 == 0){
                result = "tails";
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Tossing a Coin!");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("Coin Toss: " + result);
            return result;
        }


        // Multiple
        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            for(int i = 0; i < num; i++)
            {
                string result = TossCoin();
                if(result == "heads")
                {
                    heads += 1;
                }
                else
                {
                    tails += 1;
                }
            }

            double ratio = (heads/tails);
            System.Console.WriteLine($"Ratio of {heads} heads to {tails} tails in {num} tosses is {ratio}");
            return ratio;
        }

        // Names
        public static string[] Names()
        {
            string[] Names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            List<string> NewNames = new List<string>();
            Array.Sort(Names);
            foreach(var name in Names)
            {
                System.Console.WriteLine(name);
            }
            foreach(var name in Names)
            {
                if(name.Length > 5)
                {
                    NewNames.Add(name);
                }
            }
            foreach(var person in NewNames)
            {
                System.Console.WriteLine("Names with more than 5 characters: " + person);
            }
            return NewNames.ToArray();
        }


    }
}

