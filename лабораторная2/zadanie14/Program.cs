using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double result;
            if (b > 0)
            {
                Console.WriteLine("Значение B должно быть не положительным");
                return;
            }
            result = a * Math.Sqrt(-7 * b);
            Console.WriteLine("{0:F4}", result);


        }
    }
}
