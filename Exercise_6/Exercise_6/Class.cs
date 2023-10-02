using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Class
    {
        public string ClassName {  get; set; }
        private List<Student> students;
        public List<Student> GetStudents() { return students; }
        public Class()
        {
            ClassName = string.Empty;
            students = new List<Student>();
        }
        public Class(string className)
        {
            ClassName = className;
            students = new List<Student>();
        }

        public void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("Input student full name:");
            string? studentName = Console.ReadLine();

            InputAge:
            Console.WriteLine("Input student age:");
            bool isNum = Int32.TryParse(Console.ReadLine(), out int studentAge);
            if(!isNum) goto InputAge;

            Console.WriteLine("Input student hometown: (Thanh Hoa, Da Nang, Ho Chi Minh, ...)");
            string? studentHomeTown = Console.ReadLine();

            students.Add(new Student(studentName, studentAge, studentHomeTown));
            Console.WriteLine($"A student has just added: {students.Last().ToString()}");
            Console.WriteLine();
        }

        public List<Student> GetStudentOfAge20()
        {
            List<Student> _students = students.Where(s => s.Age == 20).ToList();
            return _students;
        }
        public List<Student> GetStudentOfAge23AndFromDN()
        {
            List<Student> _students = students.Where(s => s.Age == 23 && s.HomeTown.ToLower() == "da nang").ToList();
            return _students;
        }
    }
}
