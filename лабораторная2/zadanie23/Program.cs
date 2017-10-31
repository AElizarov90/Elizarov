using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie23
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                    return;

            }
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            double discriminant;
            discriminant = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("{0:F4}", discriminant);
        }
    }
}
