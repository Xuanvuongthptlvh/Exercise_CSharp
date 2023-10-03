using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Experience : Employee
    {
        public int? ExpInYear { get; set; }
        public string ProSkill {  get; set; }
        public Experience()
        {
            ExpInYear = null;
            ProSkill = string.Empty;
        }
        public Experience(string fullName, DateOnly? birthDay, string phone, string email, int? expInYear, string proSkill) : base(fullName, birthDay, phone, email)
        {
            ExpInYear = expInYear;
            ProSkill = proSkill;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {FullName}, Birthday: {BirthDay}, Phone: {Phone} " +
                $"\n Email: {Email}, Employee_type: Experience, ExpInYear: {ExpInYear}, ProSkill: {ProSkill}.");
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
