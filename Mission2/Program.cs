using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numThrows = 0;
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            numThrows = Convert.ToInt32(Console.ReadLine());

            int[] numFrequency = new int[11];
            double[] numProportion = new double[11];

            // roll the dice for inputed number of times
            Random rnd = new Random();
            for (int i = 0; i < numThrows; i++)
            {
                int diceOne = rnd.Next(1, 7);
                int diceTwo = rnd.Next(1, 7);
                int sumDice = diceOne + diceTwo;
                numFrequency[(sumDice - 2)]++;
            }

            // calculate the proportions of the possible nums from the rolls
            double tempNum = 0;
            for (int i = 0; i < numProportion.Length; i++)
            {
                tempNum = Convert.ToDouble( numFrequency[i]) / Convert.ToDouble(numThrows);
                tempNum = Math.Round(tempNum * 100);
                numProportion[i] = tempNum;
            }

            // output the results
            Console.WriteLine("DICE ROLLING SIMILATION RESULTS: ");
            Console.WriteLine("Each * represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls = " + numThrows + ".");

            // calculate the number of asterisks

            string asterisks = "";
            string separator = ":  ";
            for (int i = 0; i < numProportion.Length; i++)
            {
                
                for (int j = 0; j < numProportion[i]; j++)
                {
                    asterisks = asterisks + "*";
                }

                if (i >= 8)
                {
                    separator = ": ";
                }
                Console.WriteLine((i + 2) + separator + asterisks);
                asterisks = "";
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
