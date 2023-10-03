using System;
using Exercise_4;

public class Program
{
    static void Main(string[] args)
    {
        Input:
        Console.Clear();
        Console.WriteLine("Welcome to FSOFT Town. Please enter the number of families:");
        int n = Int32.Parse(Console.ReadLine());
        if (n < 1)
        {
            Console.WriteLine("Invalid");
            Console.ReadLine();
            goto Input;
        }
        
        Town Fsoft = new Town();
        Fsoft.NoOfFamily = n;
        Fsoft.AddFamily();
        Fsoft.ShowInfor();
    }
}