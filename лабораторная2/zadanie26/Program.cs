using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение a должно быть не равно нулю");
                return;
            }
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            double d;
            d = Convert.ToDouble(Console.ReadLine());
            if (d <= 0)
            {
                Console.WriteLine("Значение d должно быть не равно нулю");
                return;

            }
            double R;
            R = (a * b + b * c) / (a * d);
            Console.WriteLine("{0:F4}", R);


        }
    }
}
