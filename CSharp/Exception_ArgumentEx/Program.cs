using System;
using System.Threading.Channels;

/*Raised when a non-null argument that is passed to a method is invalid*/
public class Example
{
    static void Main(string[] args)
    {
        int[] values = { 10, 7 };
        foreach(var value in values)
        {
            try
            {
                Console.WriteLine("{0} devided by 2 is {1}", value, DividedByTwo(value));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
            }
        }
    }
    
    static int DividedByTwo(int num)
    {
        if (num % 2 == 1)
            throw new ArgumentException($"{num} is not an even number");
        return num / 2;
    }
}