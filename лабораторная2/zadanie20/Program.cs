using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass;
            mass = Convert.ToDouble(Console.ReadLine());
            if (mass < 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            double velocity;
            velocity = Convert.ToDouble(Console.ReadLine());
            if (velocity < 0)
            {
                Console.WriteLine("Значение velocity должно быть положительным");
                return;
            }
            double height;
            height = Convert.ToDouble(Console.ReadLine());
            if (height < 0)
            {
                Console.WriteLine("Значение height должно быть неотрицательным");
                return;
               
            }
            double g;
            g = 9.8067;
            double kineticEnergy = (mass * Math.Pow(velocity,2)/2);
            double potentialEnergy = mass * g * height;
            Console.WriteLine("Кинетическая энергия составляет:{0:F4} Дж,\nПотенциальная энергия составляет:{1:F4} Дж", kineticEnergy, potentialEnergy);

        }
    }
}
