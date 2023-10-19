using System;

public class Example
{
    public static void Main(string[] args)
    {
        int num1 = 100;
        int num2 = 0;

        try
        {
            Console.WriteLine(num1 / num2);
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}