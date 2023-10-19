using System;

class Program
{
    class Student
    {
        public string Name { get; set; }
    }
    static void Print(int i)
    {
        i = 100;
        Console.WriteLine(i);
    }

    static void Show(string s)
    {
        s = "Hi C#";
        Console.WriteLine(s);
    }
    static void ChangeName(Student student)
    {
        student.Name = "Bill";
    }
    static void Main(string[] args)
    {
        // Value data type
        /*int i = 200;
        Console.WriteLine(i);
        Print(i);
        Console.WriteLine(i);*/

        // Reference data type
        // Note: string is a reference type but it is immutable.
        string str = "Hello C#";
        //str = "Hi C#";
        Show(str);
        Console.WriteLine(str);

        Student s = new Student();
        s.Name = "Steve";
        ChangeName(s);
        Console.WriteLine(s.Name);
    }
}