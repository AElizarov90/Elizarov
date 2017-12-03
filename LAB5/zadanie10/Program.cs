using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            X  = Convert.ToDouble(Console.ReadLine());
            double Y;
            Y = Convert.ToDouble(Console.ReadLine());
            double Z;
            Z = Convert.ToDouble(Console.ReadLine());
            double result;
            double a;
            a = Math.Pow(X, 2);
            double b;
            b = Math.Pow(Y, 2);
            double c;
            c = Math.Pow(Z, 2);
            result = ("{0:F4} , {1:F4} , {2:F4}", a, b, c));



        }
    }
}
