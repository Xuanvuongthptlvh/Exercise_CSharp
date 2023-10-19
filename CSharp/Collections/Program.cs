using Collections_ArrayList;
using System;
using System.Collections;

namespace Collections_ArrayList
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList();

            arlist.Add(1);
            arlist.Add(null);
            arlist.Add("Vuong");

            var arlist2 = new ArrayList()
            {
                2, "Vuong", 4.5
            };

            arlist2.Insert(1, "FPT");
            foreach (var item in arlist2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arlist2.Contains("Vuong"));

            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            //get all students whose name is Bill
            var result = from s in students
                         where s.Name == "Bill"
                         select s;

            foreach (var student in result)
                Console.WriteLine(student.Id + ", " + student.Name);

            string[] cities = new string[3] { "Hanoi", "London", "Mumbai" };

            var popularcities = new List<string>();

            popularcities.AddRange(cities);

            foreach (var item in popularcities)
            {
                Console.WriteLine(item);
            }

            var numbers = new List<int>() { 10, 20, 30, 50, 60, };
            numbers.Insert(0, 1);
            Console.WriteLine(numbers[0]);
        }
    }
}

namespace Collections_SortedList
{
    public class Program
    {
        
        /*public static void Main(string[] args)
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(0, "Zero");
            list.Add(1, "One");
        }*/
    }
}