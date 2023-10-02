using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Student
    {
        public string FullName { get; set; }
        public int? Age { get; set; }
        public string HomeTown { get; set; }

        public Student()
        {
            FullName = string.Empty;
            Age = null;
            HomeTown = string.Empty;
        }
        public Student(string fullName, int? age, string homeTown)
        {
            FullName = fullName;
            Age = age;
            HomeTown = homeTown;
        }
        public override string ToString()
        {
            return $"Name: {FullName}, Age: {Age}, HomeTown: {HomeTown}.";
        }
    }
}
