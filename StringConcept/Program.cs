using System;

namespace StringConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Reading from
            string Name; // simple dec
            Console.WriteLine(Name = "Test");
            //Simple String declaration
            string Name1 = "Hello C#";

            //Access Strings - it will display the value of char
            Console.WriteLine("Access Strings ex: index value is -->" + Name1[3]);

            Console.WriteLine("Access String: Specific index in a string-->" + Name1.IndexOf("C"));

            //String Concatenation
            string fristName = "Sindhu";
            string lastName = " Patil";
            string completeName = fristName + lastName;
            string fullName = string.Concat(fristName, lastName);
            Console.WriteLine("String Concatenation without Concat() Method-->"+ completeName);
            Console.WriteLine("String Concatenation with Concat() Method-->" + fullName);
            
            //String Interpolation
            string Interpolationex = $"String Interpolation example is :{fristName} {lastName}";
            Console.WriteLine(Interpolationex);
            
            //String SubString
            string counry = "Canada India";
            Console.WriteLine(counry.Substring(counry.IndexOf("I")));
            
            //String Length
            Console.WriteLine("String Lenght--> " + counry.Length);
            
            //String lowerCase, UpperCase
            Console.WriteLine("String LowerCase Method()-->" + counry.ToLower());
            Console.WriteLine("String UpperCase Method()-->" + counry.ToUpper());
            Console.ReadLine();


        }
    }
}
