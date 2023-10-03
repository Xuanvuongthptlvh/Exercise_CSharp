using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Intern : Employee
    {
        public string Majors { get; set; }
        public string Semester { get; set; }
        public string University_Name { get; set; }

        public Intern()
        {
            Majors = string.Empty;
            Semester = string.Empty;
            University_Name = string.Empty;
        }
        public Intern(string fullName, DateOnly? birthDay, string phone, string email, string majors, string semester, string university_Name) : base(fullName, birthDay, phone, email)
        {
            Majors = majors;
            Semester = semester;
            University_Name = university_Name;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {FullName}, Birthday: {BirthDay}, Phone: {Phone} " +
                $"\n Email: {Email}, Employee_type: Intern, Majors: {Majors}, Semester: {Semester}, University_Name = {University_Name}.");
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
