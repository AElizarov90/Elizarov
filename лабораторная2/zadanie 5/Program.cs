using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            double volume;
            if (radius > 0)
            {
                volume = (Math.PI*4 * radius * radius * radius/3);
                Console.WriteLine("{0:F4}", volume);

            }
            else
                Console.WriteLine("Значение radius должно быть положительным");
        }
    }
}
