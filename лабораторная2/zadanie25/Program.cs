using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double cInGrad;
            cInGrad = Convert.ToDouble(Console.ReadLine());
            double cInRad;
            cInRad = cInGrad * Math.PI / 180;
            double z;
            z = Math.Cos(cInRad);
            double result;
            result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * z);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
