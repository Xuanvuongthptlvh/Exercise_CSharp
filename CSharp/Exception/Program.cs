using System;

/*Multiple catch blocks called exception filters.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number to divide 100: ");

        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }

        catch (DivideByZeroException ex)
        {
            Console.Write("Cannot divide by zero. Please try again.");
        }
        catch (InvalidOperationException ex)
        {
            Console.Write("Invalid operation. Please try again.");
        }
        catch (FormatException ex)
        {
            Console.Write("Not a valid format. Please try again.");
        }
        catch (Exception ex) // The last
        {
            Console.Write("Error occurred! Please try again.");
        }
        finally // be always be executed
        {
            Console.WriteLine("\nDone!");
        }
    }

}