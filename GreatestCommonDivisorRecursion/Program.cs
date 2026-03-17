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
int number1 = 0, number2 = 0, result = 0;

// Call the GetInput method
Utility.GetInput(ref number1, ref number2);

// Call the GCD method
result = Utility.GreatestCommonDivisor(number1, number2);

// Print the result to the user
Console.WriteLine($"The GCD of {number1} and {number2} is {result}.");

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
    internal static int GetInput(ref int num1, ref int num2)
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

        return num2;
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
}