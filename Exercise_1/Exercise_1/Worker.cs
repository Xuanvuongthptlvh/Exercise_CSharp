using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Worker : Officer
    {
        public int Level { get; set; }
        public Worker(string name, int age, string gender, string address, int level) : base(name, age, gender, address)
        {
            Level = level;
        }
  
        public override string ToString()
        {
            return $"Worker - {Name}, {Age}, {Gender}, {Address}, {Level}";
        }

    }
}
