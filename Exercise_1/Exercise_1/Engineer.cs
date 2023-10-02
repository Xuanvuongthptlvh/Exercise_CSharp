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
    public class Engineer : Officer
    {
        public string Major {  get; set; }
        public Engineer(string name, int age, string gender, string address, string major) : base(name, age, gender, address)
        {
            Major = major;
        }

        public override string ToString()
        {
            return $"Engineer - {Name}, {Age}, {Gender}, {Address}, {Major}";
        }

    }
}
