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
            double xInGrad;
            xInGrad = Convert.ToDouble(Console.ReadLine());
            double result;
            result = Math.Sin(xInGrad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
