using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            X = Convert.ToInt32(Console.ReadLine());
            int Y;
            Y = Convert.ToInt32(Console.ReadLine());
            int Z;
            Z = Convert.ToInt32(Console.ReadLine());
            if (X == Y) 
            {
                Console.WriteLine("Среди чисел есть равные");
                return;
            }
            if (X == Z)
            {
                Console.WriteLine("Среди чисел есть равные");
                return;

            }
            if (Z == Y)
            {
                Console.WriteLine("Среди чисел есть равные");
                return;

            }
            else
            {
                Console.WriteLine("Числа не равны друг другу");

            }

        }
    }
}
