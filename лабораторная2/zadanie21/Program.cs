﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie21
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1;
            R1 = Convert.ToDouble(Console.ReadLine());
            if (R1 <= 0)
            {
                Console.WriteLine("Значение R1 должно быть не равно нулю");
                return;
            }
            double R2;
            R2 = Convert.ToDouble(Console.ReadLine());
            if (R2 <= 0)
            {
                Console.WriteLine("Значение R2 должно быть не равно нулю");
                return;

            }
            double result;
            result = (1 / R1) + (1 / R2);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
