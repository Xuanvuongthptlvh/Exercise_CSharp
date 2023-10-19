using System;
using System.Collections;
using System.Net.Sockets;

namespace Association
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


    }

    public class StdudentRespoistory
    {
        public Student GetStudent(int StudentId)
        {
            return new Student();
        }

        public bool Save(Student student)
        {
            Console.WriteLine("Student saved successfully.");
            return true;
        }

        public bool Validate(Student student)
        {
            Console.WriteLine("Student does not exist.");
            return true;
        }
    }
    /*class Program
    {
        public static void Main(string[] args)
        {

        }
    }*/
}

namespace Compostion
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set;}
        public string LastName { get; set; }

        public Address HomeAddress { get; set; }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }

    /*class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 1;
            student.FirstName = "Le";
            student.LastName = "Vuong";
            student.MiddleName = "Xuan";

            student.HomeAddress = new Address();
            student.HomeAddress.AddressId = 36;
            student.HomeAddress.City = "Thanh Hoa";
            student.HomeAddress.Country = "Viet Nam";
            Console.WriteLine(student.HomeAddress.AddressId);
        }
    }*/
}

namespace Aggregation
{

    class Program
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }

            public Course EnrolledCourse { get; set; }
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public IList Topics { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }
        public static void Main(string[] args)
        {

        }
    }
}