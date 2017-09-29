using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);

            // But because a and b are both integers, it will return a result of 3, rounding to the closest whole number
            Console.WriteLine(a / b);
            // So have to specify they are a float for an accurate result
            Console.WriteLine((float)a / (float)b);

            var c = 1;
            var d = 2;
            var e = 3;
            // C# behaves as expected with math equations, result is 7
            Console.WriteLine(c + d * e);

            Console.WriteLine(c > d);

            Console.WriteLine(c == d);
            Console.WriteLine(c != d);
            // double negative 
            Console.WriteLine(!(c != d));

            Console.WriteLine(e > d && d > c);
        }
    }
}
