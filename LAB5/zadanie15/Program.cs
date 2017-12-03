using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            A = Convert.ToInt32(Console.ReadLine());
            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            int B;
            B = Convert.ToInt32(Console.ReadLine());
            if (B < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            int C;
            C = Convert.ToInt32(Console.ReadLine());
            if (C < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (A == B )
            {
                Console.WriteLine("Треугольник является равнобедренным");
            }
            if (A == C)
            {
                Console.WriteLine("Треугольник является равнобедренным");
            }
            if (B == C)
            {
                Console.WriteLine("Треугольник является равнобедренным");
            }

            if(A!=B&&B!=C)
           

            {
                Console.WriteLine("Треугольник не является равнобедренным");
            }
            
           
           
        }
    }
}
