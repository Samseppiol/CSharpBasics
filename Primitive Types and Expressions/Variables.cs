using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            // Characters defined with single quotes
            char character = 'A';
            // Strings defined with double quotes
            string name = "Jack";
            bool isWorking = true;

            // Or just use var, will pick up whatever the type is automatically
            var numberTwo = 4;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);
            Console.WriteLine(numberTwo);

            // Format string, basically saying display min value as the first argument and maxvalue as the second
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
