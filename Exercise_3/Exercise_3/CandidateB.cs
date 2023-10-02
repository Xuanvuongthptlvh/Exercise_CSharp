using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_3
{
    public class CandidateB : Candidate
    {
    public static string B_1 = "Math";
    public static string B_2 = "Chemistry";
    public static string B_3 = "Biology";

    public CandidateB(string id, string name, string address, int priority) : base(id, name, address, priority) { }

    public override string ToString()
        {
            return $"CandidateB - {Id}, {Name}, {Address}, {Priority}, Subject: {B_1}, {B_2}, {B_3}";
        }
    }
}
