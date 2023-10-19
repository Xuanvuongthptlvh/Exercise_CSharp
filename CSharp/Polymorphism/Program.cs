using System;

namespace Compile_Time_Polymorphism
{
    class ConsolePrinter
    {
        public void Print(string msg) { Console.WriteLine(msg); }

        public void Print(string msg1, string msg2) { Console.WriteLine($"{msg1} {msg2}"); }

        public void Print(string msg1, string msg2, string msg3) { Console.WriteLine($"{msg1} {msg2} {msg3}"); }

        public void Print(int a)
        {
            Console.WriteLine($"Integer {a}");
            
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ConsolePrinter CP = new ConsolePrinter();
            CP.Print("Hello");
            CP.Print(100);
            CP.Print("Hello", "Hi");
            CP.Print("Hello", "Hi", "Good");
        }
    }
}

namespace Run_Time_Polymorphism // Denpending on the type of the object not the type of the variable
{
    class Person
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hi! I am a person.");
        }
    }

    class Employee : Person
    {
        public override void Greet()
        {
            Console.WriteLine("Hello! I am a manager.");
        }
    }
    /*class Program
    {
        public static void Display(Person p)
        {
            p.Greet();
        }

        public static void Main()
        {
            Person p1 = new Person();
            //Display(p1);
            p1.Greet();

            Person p2 = new Employee();
            //Display(p2);
            p2.Greet();

            Employee emp = new Employee();
            //Display(emp);
            emp.Greet();
        }
    }*/
}


namespace HidingMethod
{
    class Person
    {
        public void Greet()
        {
            Console.WriteLine("I am a person.");
        }
    }

    class Employee : Person
    {
        public new void Greet()
        {
            Console.WriteLine("I am a manager.");
        }
    }
    /*class Program
    {
        public static void Main()
        {
            Person p1 = new Person();
            p1.Greet();

            Person p2 = new Employee(); // Depending on the type of variable
            p2.Greet();

            Employee emp = new Employee();
            emp.Greet();
        }
    }*/
}