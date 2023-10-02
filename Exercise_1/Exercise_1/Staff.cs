using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_1
{
    public class Staff : Officer
    {
        public string Task {  get; set; }
        public Staff(string name, int age, string gender, string address, string task) : base(name, age, gender, address)
        {
            Task = task;
        }

        public override string ToString()
        {
            return $"Staff - {Name}, {Age}, {Gender}, {Address}, {Task}";
        }
    }
}
