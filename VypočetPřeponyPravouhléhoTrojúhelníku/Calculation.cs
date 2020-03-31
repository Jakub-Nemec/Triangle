using System;
namespace VypočetPřeponyPravouhléhoTrojúhelníku
{
    public class Calculation
    {
        public void sumOfTrialgl()
        {
            Console.WriteLine("Calculation of the hypotenuse.");
            Console.Write("Enter the first line of the triangle: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter the second line of the triangle: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Pow(a, 2) + Math.Pow(b, 2);

            Console.WriteLine("{0} ^ 2 + {1} ^ 2 = {2}", a, b, c);
            Console.WriteLine("Square root z {0} je: " + Math.Sqrt(c), c);
        }
    }
}
