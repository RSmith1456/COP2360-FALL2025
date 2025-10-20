using System;
using static System.Console;

public class Mod4Task
{
    
    public static void Main(string[] args)
    {
        
        WriteLine("Enter first number: ");
        string input1 = ReadLine();
        
        WriteLine("Enter second number: ");
        string input2 = ReadLine();
        
        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            int result = Divide(number1, number2);
            WriteLine($"\nThe result of {number1} divided by {number2} is: {result}\n");
        }
        catch (FormatException ex)
        {
            WriteLine("\nError: One or both of the inputs are not valid integers. This could be due to the one or more of the inputs being a decimal value, or not being a numerical value.\n");
            WriteLine($"Detailed error message: {ex.Message}\n");
        }
        catch (DivideByZeroException ex)
        {
            WriteLine("\nError: Division by zero is not allowed. This is due to zero's behavior with multiplication.\n");
            WriteLine($"Detailed error message: {ex.Message}\n");
        }
        catch (OverflowException ex)
        {
            WriteLine($"\nOne or both of the inputs are too large for this program. The highest value integer this program can handle is:\n{Int32.MaxValue}.\n");
            WriteLine($"Detailed error message: {ex.Message}\n");
        }
        catch (Exception ex)
        {
            WriteLine("\nAn unexpected error occured.\n");
            WriteLine($"Detailed error message: {ex.Message}\n");
        }

        WriteLine("Press any key to exit...\n");
        ReadKey();
    }
    
    static int Divide(int a, int b)
    {
        return a / b;
    }
}