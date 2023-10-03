using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string PersonID { get; set; }

        public Person(string fullName, int age, string job, string personID)
        {
            FullName = fullName;
            Age = age;
            Job = job;
            PersonID = personID;
        }

        public override string ToString()
        {
            return $"FullName: {FullName}, Age: {Age}, Job: {Job}, PersonID: {PersonID}.";
        }
    }
}
