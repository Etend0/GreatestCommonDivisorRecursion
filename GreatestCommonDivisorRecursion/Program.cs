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



//--------------------------------------------------------
// End of the Main Method
//--------------------------------------------------------

public class Utility
{
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        // Declare and initialize
        int remainder = 0;

        // Base case: num2 is 0
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