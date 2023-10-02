using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Officer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Officer(string name, int age, string gender, string address)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
        }

        public Officer()
        {
            Name = string.Empty;
            Age = 0;
            Gender = string.Empty;
            Address = string.Empty;
        }
    }
}
