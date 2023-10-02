using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Priority { get; set; }
        public Candidate(string id, string name, string address, int priority)
        {
            Id = id;
            Name = name;
            Address = address;
            Priority = priority;
        }
    }
}
