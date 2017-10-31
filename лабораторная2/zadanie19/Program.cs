using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity;
            initialVelocity = Convert.ToDouble(Console.ReadLine());
            if (initialVelocity < 0)
            {
                Console.WriteLine("Начальная скорость должно быть неотрицательна");
                return;
            }
            double time;
            time = Convert.ToDouble(Console.ReadLine());
            if (time <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                    return;
            }
            double acceleration;
            acceleration = Convert.ToDouble(Console.ReadLine());
            double distance;
            distance = (initialVelocity * time)+(acceleration*Math.Pow(time,2)/2);
            Console.WriteLine("{0:F2}", distance);
        }
    }
}
