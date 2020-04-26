using System;
using static System.Console;

namespace salesletter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main - Exercise 1
           Examples(1);
           DisplayContactInfo();

           //Main - Exercise 2
           Examples(2);
           WriteLine("Please write the lenght of the room in feet");
           double length = Convert.ToDouble(ReadLine());
           WriteLine();

           WriteLine("Please write the width of the room in feet");
           double width = Convert.ToDouble(ReadLine());
           WriteLine();

           WriteLine("The final price for painting will be {0}", PaintingEstimate(length, width));
           WriteLine();

           //Main - Exercise 3
           Examples(3);
           WriteLine("Write a number of miles");
           double miles = Convert.ToDouble(ReadLine());
           WriteLine();

            WriteLine("{0} miles in kilometers are {1}.", miles, ConvertMilesToKilometers(miles));
            WriteLine();

        }

        //Method - Exercise 1
        static void DisplayContactInfo()
        {
            WriteLine("******************************");
            WriteLine("Shop at Shopper's World");
            WriteLine("The best bargains from around the world");
            WriteLine("www.shoppersworldbargains.com");
            WriteLine("******************************");
            WriteLine();
        }

        //Method - Exercise 2
        static double PaintingEstimate(double value1, double value2)
        {
            const double pricePerSquare = 6;

            double squareFoot = value1 * value2;
            return squareFoot * pricePerSquare;
        }

        //Method - Exercise 3
        static double ConvertMilesToKilometers(double value1)
        {
            const double kilometersCal = 1.60934;

            return value1 * kilometersCal;
        }

        //Example
        static void Examples(double value1)
        {
            WriteLine("******************************");
            WriteLine("Example {0}", value1);
            WriteLine("******************************");
            WriteLine();
        }

    }
}
