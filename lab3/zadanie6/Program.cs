using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocityInKmH;
            velocityInKmH = Convert.ToDouble(Console.ReadLine());
            if (velocityInKmH < 0)
            {
                Console.WriteLine("Значение velocityInKmH должно быть неотрицательным");
                return;

            }
            double velocityInMS;
            velocityInMS = Convert.ToDouble(Console.ReadLine());
            if (velocityInMS < 0)
            {
                Console.WriteLine("Значение velocityInMS должно быть неотрицательным");
                return;

            }
            double R;
            R = velocityInMS * 60 * 100;
            double R2;
            R2 = velocityInKmH;
            if (R < R2)
            {
                Console.WriteLine("{0:F2} км/ч меньше {1:F2} м/с", velocityInKmH, velocityInMS);
            }
            else 
            {
                Console.WriteLine("{0:F2} м/с меньше {1:F2} км/ч", velocityInMS, velocityInKmH);

            }
        }
    }
}
