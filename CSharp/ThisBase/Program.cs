using System;

public class ParentClass
{
    protected int number;

    public ParentClass(int number)
    {
        this.number = number;
    }

    public virtual void PrintNumber()
    {
        Console.WriteLine("ParentClass: " + number);
    }
}

public class ChildClass : ParentClass
{
    private string message;

    public ChildClass(int number, string message) : base(number)
    {
        this.message = message;
    }

    public override void PrintNumber()
    {
        base.PrintNumber();
        Console.WriteLine("ChildClass: " + number);
    }

    public void PrintMessage()
    {
        Console.WriteLine("Message: " + message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ChildClass child = new ChildClass(10, "Hello");
        child.PrintNumber();
        child.PrintMessage();

        Console.ReadLine();
    }
}