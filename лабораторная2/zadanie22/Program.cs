using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie22
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass;
            mass = Convert.ToDouble(Console.ReadLine());
            if (mass <= 0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;

            }
            double g;
            g = 9.8067;
            double aInGrad;
            aInGrad = Convert.ToDouble(Console.ReadLine());
            double aInRad;
            aInRad = aInGrad * Math.PI / 180;
            double a;
            a = Math.Cos(aInRad);
            double result;
            result = mass * g * a;
            Console.WriteLine("{0:F6}", result);
        }
    }
}
