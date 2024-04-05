using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    internal class Program
    {
        static void GetParamesSphere(double a, out double v, out double s)
        {
            v = Math.Pow(a, 3);
            s = 6 * Math.Pow(a, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения ребра куба");
            double a=Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetParamesSphere(a, out s, out v);
            Console.WriteLine("Объем куба {0}, Площадь поверхности куба {1}",s,v);
            Console.ReadKey();

        }
    }
}
