using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "John";
            var lastName = "Doe";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);


            var names = new String[3] { "Jack", "John", "James" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // Multi line string using a verbatim string
            var text = @"Hello World
This Is 
A multiline string";
            Console.WriteLine(text);

        }
    }
}
