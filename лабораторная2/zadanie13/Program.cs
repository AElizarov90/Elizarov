using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            X = Convert.ToDouble(Console.ReadLine());
            double result;
            if (X > 61)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            result = 3*Math.Sqrt(61 - X);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
