using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double result;
            double koren;
            koren = a * Math.Pow(x, 2) + b * x + c;

            if (koren < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
            }
            else
            {

                result = 1 / (Math.Sqrt(a * Math.Pow(x, 2) + b * x + c));
                Console.WriteLine("{0:F4}", result);
            }
        }
    }
}