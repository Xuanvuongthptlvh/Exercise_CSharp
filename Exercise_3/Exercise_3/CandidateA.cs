using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_3
{
    internal class CandidateA : Candidate
    {
        
    public static string A_1 = "Math";
    public static string A_2 = "Physics";
    public static string A_3 = "Chemistry";
    public CandidateA(string id, string name, string address, int priority) : base(id, name, address, priority) { }

    public override string ToString()
        {
            return $"CandidateA - {Id}, {Name}, {Address}, {Priority}, Subject: {A_1}, {A_2}, {A_3}.";
        }
    }
}
