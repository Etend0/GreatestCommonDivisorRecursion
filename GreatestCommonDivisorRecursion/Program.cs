using System.Collections;
using System.Diagnostics;

/*
 * Elijah Hodge
 * CST - 250
 * 03/16/2026
 * Factorial Recursion
 * Activity 3
 */

//--------------------------------------------------------
// Start of the Main Method
//--------------------------------------------------------

// Declare and initialize
Stopwatch stopwatch = new Stopwatch(); // Create a stopwatch to track the time taken to calculate the GCD between recursion and iteration
int number1 = 0, number2 = 0, number3 = 0, result = 0;

// Call the GetInput method
Utility.GetInput(ref number1, ref number2, ref number3);

// Start the stopwatch
stopwatch.Start();

// Call the GCD method
result = Utility.GreatestCommonDivisor(number1, number2);

if (number3 != 0)
{
    // Call the GCD method with the third number
    result = Utility.GreatestCommonDivisor(result, number3);

    // Stop the stopwatch
    stopwatch.Stop();

    // Print the result to the user
    Console.WriteLine($"The GCD of {number1} and {number2} and {number3} is {result}.");

    // Print the time taken to calculate the GCD using recursion
    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to calculate the GCD of {number1}, {number2}, and {number3} using recursion.");

    // Restart the stopwatch to track the time taken to calculate the GCD using iteration
    stopwatch.Restart();

    // Call the GCD Iterative method
    result = Utility.GreatestCommonDivisorIterative(number1, number2);

    // Call the GCD Iterative method with the third number
    result = Utility.GreatestCommonDivisorIterative(result, number3);

    // Stop the stopwatch
    stopwatch.Stop();

    // Print the result to the user
    Console.WriteLine($"The GCD of {number1} and {number2} and {number3} from iterating is {result}.");

    // Print the time taken to calculate the GCD using iteration
    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to calculate the GCD of {number1}, {number2}, and {number3} using iteration.");
}
else
{
    // Stop the stopwatch
    stopwatch.Stop();

    // Print the result to the user
    Console.WriteLine($"The GCD of {number1} and {number2} is {result}.");

    // Print the time taken to calculate the GCD using recursion
    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to calculate the GCD of {number1} and {number2} using recursion.");

    // Restart the stopwatch to track the time taken to calculate the GCD using iteration
    stopwatch.Restart();

    // Call the GCD Iterative method
    result = Utility.GreatestCommonDivisorIterative(number1, number2);

    // Stop the stopwatch
    stopwatch.Stop();

    // Print the result to the user
    Console.WriteLine($"The GCD of {number1} and {number2} from iterating is {result}.");

    // Print the time taken to calculate the GCD using iteration
    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} milliseconds to calculate the GCD of {number1} and {number2} using iteration.");
}

//--------------------------------------------------------
// End of the Main Method
//--------------------------------------------------------

public class Utility
{
    /// <summary>
    /// Get the user imputs
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GetInput(ref int num1, ref int num2, ref int num3)
    {
        // Declare and initialize
        string input = "";
        int output = 0;

        // Prompt the user for the first integer
        Console.Write("Please enter the first number: ");
        // Get the current input
        input = Console.ReadLine();
        // Check if the input is valid
        while (!int.TryParse(input, out output))
        {
            // Show the user an error message and prompt them again
            Console.Write("Invalid input. Please try again: ");
            // Get the new input
            input = Console.ReadLine();
        }
        // Parse the input to an integer
        num1 = int.Parse(input);

        // Prompt the user for the second integer
        Console.Write("Please enter the second number: ");
        // Get the current input
        input = Console.ReadLine();
        // Check if the input is valid
        while (!int.TryParse(input, out output))
        {
            // Show the user an error message and prompt them again
            Console.Write("Invalid input. Please try again: ");
            // Get the new input
            input = Console.ReadLine();
        }

        num2 = int.Parse(input);

        // Prompt the user for the second integer
        Console.WriteLine("If you'd like to use a third number, enter it here, if not, input 0");
        Console.Write("Please enter the third number: ");
        // Get the current input
        input = Console.ReadLine();
        // Check if the input is valid
        while (!int.TryParse(input, out output))
        {
            // Show the user an error message and prompt them again
            Console.Write("Invalid input. Please try again: ");
            // Get the new input
            input = Console.ReadLine();
        }

        num3 = int.Parse(input);

        return num3;
    }


    /// <summary>
    /// Calculate the GCD using recursion
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        int remainder = 0;
        if (num1 == 0 || num2 == 0)
        {
            // Return the greatest common divisor
            return num1;
        }
        else
        {
            // Get the remainder of dividing num1 and num2
            remainder = num1 % num2;
            // Print an update to the user
            Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");
            // Call the recursive function of the second number and the remainder
            return GreatestCommonDivisor(num2, remainder);
        }
    }

    /// <summary>
    /// Calculate the GCD using iteration
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisorIterative(int num1, int num2)
    {
        int largestMatchingDivisor = 0;
        // Create lists to hold the divisors of each number
        List<int> num1Divisors = new List<int>();

        List<int> num2Divisors = new List<int>();

        // Print an update to the user
        Console.WriteLine("Iterating to find the divisors of the first number...");

        // Loop through each number from the first list and check if it is a divisor
        for (int i = 1; i <= num1; i++)
        {
            // If the number is a divisor, add it to the list
            if (num1 % i == 0)
            {
                // Add the divisor to the list
                num1Divisors.Add(i);
            }
        }

        // Print an update to the user
        Console.WriteLine("Iterating to find divisors of the second number...");

        // Loop through each number from the second list and check if it is a divisor
        for (int i = 1; i <= num2; i++)
        {
            // If the number is a divisor, add it to the list
            if (num2 % i == 0)
            {
                // Add the divisor to the list
                num2Divisors.Add(i);
            }
        }

        // Print an update to the user
        Console.WriteLine("Looking for the largest matching divisor between the two...");

        // Find the common elements between the two lists
        var commonElements = num1Divisors.Intersect(num2Divisors);

        // If there are common elements, find the largest one
        if (commonElements.Any())
        {
            // Get the largest common element
            largestMatchingDivisor = commonElements.Max();
        }
        else
        {
            // If there are no common elements, print a message to the user
            Console.WriteLine("These numbers do not have a common divisor.");
        }

        // Return the largest common element
        return largestMatchingDivisor;
    }
}