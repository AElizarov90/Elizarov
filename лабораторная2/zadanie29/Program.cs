using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie29
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, X = double.Parse(Console.ReadLine());
            if (X < 5)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
            }
            else
            {
                R = (Math.Sqrt(X + 5) + Math.Sqrt(X - 5)) / (2 * Math.Sqrt(X));
                Console.WriteLine("{0:F6}", R);
            }
        }
    }
}