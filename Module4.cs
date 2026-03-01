using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);
                
            int result = Divide (number1, number2);
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid integers");
            LogException(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: One or both of the inputs are too large.");
            LogException(ex);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            LogException(ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            LogException(ex);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    static int Divide(int a, int b)
    {
        return a / b;
    }

    static void LogException(Exception ex)
    {
        Console.WriteLine($"Exception logged: {ex.Message}");
    }
}