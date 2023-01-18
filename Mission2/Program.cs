using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration and instanciation
            Roller rlr = new Roller();
            int totalRolls = 0;
            int[] rollCount = new int[11];
            string outCount = "";
            int[] rollPercentage = new int[11];
            int tempPercent = 0;
            
            //Introduction and input
            Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
            totalRolls = Int32.Parse(Console.ReadLine());

            //gets random rolls from Roller class and keeps track of results
            for (int i = 0; i < totalRolls; i++)
            {
                int[] output = rlr.Rolls();
                int sum = output[0] + output[1];
                rollCount[sum - 2] = rollCount[sum - 2] + 1;

            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach ' * ' represents 1% of the total number of rolls.\nTotal number of rolls = " + totalRolls + ".\n");
            
            //Generate * to represent 1% of rolls and output histogram
            for (int i = 2; i < 13; i++)
            {
                outCount = "";
                tempPercent = rollCount[i - 2] * 100;
                tempPercent = tempPercent / totalRolls;
                rollPercentage[i - 2] = tempPercent;

                for (int j = 0; j < rollPercentage[i - 2]; j++)
                {
                    outCount = outCount + "*";
                }
                Console.WriteLine(i + ": " + outCount);
            }

            //end
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
