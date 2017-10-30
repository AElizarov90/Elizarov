using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double result;
            double y;
            double res;
            y = Convert.ToDouble(Console.ReadLine());
            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            else
            { result = x + Math.Sqrt(y); }
            if (result < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            else
            {
                res = -5 * Math.Sqrt(result);
                Console.WriteLine("{0:F4}", res);
            }


        }
    }
}
