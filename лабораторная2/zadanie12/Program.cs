using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            double yInGrad;
            yInGrad = Convert.ToDouble(Console.ReadLine());
            double yInRad;

            yInRad = yInGrad * Math.PI / 180;
            double a;
            a = Math.Cos(yInRad) * 5;
            Console.WriteLine("{0:F4}", a);
        }
    }
}
