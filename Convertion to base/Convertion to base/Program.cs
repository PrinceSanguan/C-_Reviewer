using System;

public class Program
{
    public static void Main()
    {
        // Prompt the user to enter a decimal number
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        // Convert the decimal number to binary
        string binaryRepresentation = ConvertToBinary(decimalNumber);

        // Print the binary representation
        Console.WriteLine($"The binary representation of {decimalNumber} is {binaryRepresentation}");
    }

    // Method to convert a decimal number to binary
    static string ConvertToBinary(int decimalNumber)
    {
        // Special case for 0
        if (decimalNumber == 0)
            return "0";

        string binary = "";

        // Loop until the decimal number is greater than 0
        while (decimalNumber > 0)
        {
            // Get the remainder when dividing by 2 (0 or 1)
            int remainder = decimalNumber % 2;

            // Add the remainder to the binary string (building the string backwards)
            binary = remainder + binary;

            // Divide the number by 2 to move to the next bit
            decimalNumber /= 2;
        }

        return binary; // Return the binary string
    }
}
