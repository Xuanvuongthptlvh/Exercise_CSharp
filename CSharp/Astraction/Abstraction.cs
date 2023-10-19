using System;

// Abstract Class
public abstract class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name);
    }

    public abstract void Study();
}

// Interface
public interface IPlayable
{
    void Play();
}

// Student class implementing both Person and IPlayable
public class Student : Person, IPlayable
{
    public Student(string name)
    {
        Name = name;
    }

    public override void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }

    public void Play()
    {
        Console.WriteLine(Name + " is playing.");
    }
}

public class Abstraction
{
    public static void Main(string[] args)
    {
        //Person person = new Person();

        Student student = new Student("John Smith");
        student.Introduce();
        student.Study();
        student.Play();

        Console.ReadLine();
    }
}