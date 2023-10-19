using System;
using System.Text;

namespace Stringvsstring
{
    
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            
            foreach(var item in chars)
            {
                Console.Write(item);
            }


            Console.WriteLine();
            string str = "Hello World";
            Console.WriteLine(str);

            String str2 = "Hi World";
            Console.WriteLine(str2);

            string text = "This is a \"string\" in C#";
            Console.WriteLine(text);

            string text1 = @"\\xyz\abc@";
            Console.WriteLine(text1);

            string text3 = @"This is a
multiple-line
string.";
            Console.WriteLine(text3);

            string text4 = "This is a \"string\" in C#."; // valid
            //string text6 = @"This is a "string" in C#."; // error
            //string text = @"This is a \"string\" in C#."; // error
            string text5 = @"This is a ""string"" in C#."; // valid


            string name = "Mr." + "James " + "Bond" + ", Code: 007";
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";
            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";



            StringBuilder sb = new StringBuilder("Hi! ");
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Hello World!");
            sb1.Insert(5, " C#");

            Console.WriteLine(sb1); //output: Hello C# World!
            
            
        }
    }
}