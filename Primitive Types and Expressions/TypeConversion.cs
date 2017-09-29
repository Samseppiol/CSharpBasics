using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            // Will bring back 1
            // What if it is reversed though
            // To avoid data loss explicitly specify the cast
            int j = 1;
            byte c = (byte)i;
            Console.WriteLine(c);

            //Non compatible types 
            // converting string to int
            string number = "12345";
            int k = Convert.ToInt32(number);
            Console.WriteLine(k);

            // Or string to byte 
            // Value is to large for a byte and will throw exception. Have to put it in a try catch block
            //byte d = Convert.ToByte(number);
            //Console.WriteLine(d);

            try
            {
                string value = "1234";
                byte a = Convert.ToByte(value);
                Console.WriteLine(a);

            }
            catch (Exception)
            {

                Console.WriteLine("The number can't be converted to a byte! :(");
            }

            try
            {
                string str = "true";
                bool f = Convert.ToBoolean(str);
                Console.WriteLine(f);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
