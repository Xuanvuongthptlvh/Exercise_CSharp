using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "C# World";
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        //Console.CursorSize = 100;
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome {name} to C# World");
        Console.WriteLine(Console.CursorSize);
        Console.ReadKey();
    }
}