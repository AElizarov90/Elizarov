using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInGrad;
            aInGrad = Convert.ToDouble(Console.ReadLine());
            double aInRad;
            aInRad = aInGrad * Math.PI / 180;
            Console.WriteLine("{0:F4}", aInRad);
        }
    }
}
