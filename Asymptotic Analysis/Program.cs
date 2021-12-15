using System;

namespace Asymptotic_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //The lowest time complexity possible for the sum of an array is O(n), because you are required to go through the loop 1 time.

            #region First Part
            Random randomNumber = new Random();

            int[] numbersToSum = new int[100];

            int total = 0;

            Console.WriteLine("Here are some pseudo random numbers: ");

            for (int i = 0; i < 100; i++)
            {
                numbersToSum[i] = randomNumber.Next(0, 100);
                Console.WriteLine(numbersToSum[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Here is the sum of all the numbers: ");
             
            //The total time complexity is O(n).
            for(int i = 0; i <= numbersToSum.Length - 1; i++)
            {
                total += numbersToSum[i];
            }

            Console.WriteLine(total);
            Console.ReadLine();
            #endregion

            #region Second Part
            int loopLimit = 10;
            int number = 0;

            Console.WriteLine("Here is the print of both 'for' statements to show O(N^2) complexity: ");

            for (int i = 0; i < loopLimit; i++)
            {
                for (int j = 0; j < loopLimit; j++)
                {
                    Console.WriteLine("i = " + i + " j = " + j + ".");
                    number++;
                }
            }
            Console.WriteLine("This ran " + number + " total times.");
            #endregion

            #region Third Part
            Console.WriteLine("For this section, there will be a random set of numbers, and one number will be 23, but it will be in a random location within the array. The program will look through the array and find the number 23.");

            int[] numbersToLookThrough = new int[100];

            for (int i = 0; i <= 99; i++)
            {
                numbersToLookThrough[i] = randomNumber.Next(0, 100);
                Console.WriteLine(numbersToLookThrough[i]);
            }

            int randomArrayLocation = randomNumber.Next(50, 100);
            int numberToFind = 23;
            numbersToLookThrough[randomArrayLocation] = numberToFind;

            int halfArrayAmount = numbersToLookThrough.Length/2;
            int currentNumber;
            int splitAmount = numbersToLookThrough.Length / 2;
            int count = 0;
            
            for(int i = 1; i <= halfArrayAmount; i++)
            {
                currentNumber = numbersToLookThrough[i];
                if(currentNumber == numberToFind)
                {
                    Console.WriteLine("Found the number " + numberToFind + " at the location in the array of " + i);
                    Console.ReadLine();
                }
                count++;

                if(count >= halfArrayAmount)
                {
                    splitAmount = splitAmount / 2;
                    halfArrayAmount += splitAmount;

                    Console.WriteLine("Split the array and continue.");
                }
                Console.WriteLine("Current number: " + currentNumber + " " + "Count: " + count);
            }
            #endregion
        }
    }
}
