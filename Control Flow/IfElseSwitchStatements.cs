using System;

namespace IfElseSwitchStatements
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            // If else
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }


            bool isGoldCustomer = true;
            float price;

            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            // do that using a conditional
            // the colon operator is the else
            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's summer");
                    break;

                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("Winter or Spring");
                    break;


                default:
                    Console.WriteLine("I don't understand the season");
                    break; 


            }
        }
   }
}
