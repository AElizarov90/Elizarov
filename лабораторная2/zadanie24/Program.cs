using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie24
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass1;
            mass1 = Convert.ToDouble(Console.ReadLine());
            if (mass1 <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;


            }
            double mass2;
            mass2 = Convert.ToDouble(Console.ReadLine());
            if (mass2 <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            double distance;
            distance = Convert.ToDouble(Console.ReadLine());
            if (distance <= 0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательной");
                return;

            }
            double g;
            g = 9.8067;
            double force;
            force = g * (mass1 * mass2 / Math.Pow(distance, 2));
            Console.WriteLine("{0:F4}", force);
        }
    }
}
