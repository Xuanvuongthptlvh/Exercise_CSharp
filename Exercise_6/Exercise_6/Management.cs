using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Management
    {
        public List<Class> classes {  get; set; }

        public Management()
        {
            classes = new List<Class>()
            {
                new Class("Grade 10"),
                new Class("Grade 11"),
                new Class("Grade 12")
            };
        }

        public void AddClass()
        {
            InputClass:
            Console.Clear();
            Console.WriteLine("Which class?");
            Console.WriteLine("1. Grade 10");
            Console.WriteLine("2. Grade 11");
            Console.WriteLine("3. Grade 12");
            int? input = Int32.Parse(Console.ReadLine());
            if (input != 1 && input != 2 && input != 3) goto InputClass;

            if(input == 1) classes[0].AddStudent();
            if(input == 2) classes[1].AddStudent();
            else if(input == 3) classes[2].AddStudent();
        }
        public void ShowStudentOfAge20()
        {
            Console.Clear();
            foreach(var c in  classes)
            {
                List<Student> results = c.GetStudentOfAge20();
                if(results.Count > 0)
                {
                    Console.WriteLine(c.ClassName);
                    foreach (var student in results) Console.WriteLine(student);
                }
            }
            Console.ReadLine();
        }
        public void ShowNumberOfStudentsOfAge23AndFromDN()
        {
            Console.Clear();
            foreach(var c in classes)
            {
                List<Student> results = c.GetStudentOfAge23AndFromDN();
                if(results.Count > 0)
                {
                    Console.WriteLine($"Count = {results.Count} including:");
                    Console.WriteLine(c.ClassName);
                    foreach(var student in results) Console.WriteLine( student);
                }
            }
            Console.ReadLine();
        }

    }
}
