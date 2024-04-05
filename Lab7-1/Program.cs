using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    internal class Program
    {
        static double GetHypotenuse(double a, double b, double c, double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());
            double p1 = (a1 + a2 + a3) / 2;
            Console.WriteLine("Введите стороны второго треугольника");
            double b1 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double b3 = Convert.ToDouble(Console.ReadLine());
            double p2 = (b1 + b2 + b3) / 2;
            if (p1 > p2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (p1 < p2)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();
        }
    }
}
