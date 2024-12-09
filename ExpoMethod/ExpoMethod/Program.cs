using System;
//The Exponent method takes two double parameters, baseNumber and exponent, and returns the result of Math.Pow(baseNumber, exponent).
namespace ExpoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = 2.0;
            double exponent = 3.0;
            double result = Exponent(baseNumber, exponent);

            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
        }

        static double Exponent(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }
}
