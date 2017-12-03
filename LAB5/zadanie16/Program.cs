using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            X = Convert.ToDouble(Console.ReadLine());
            double Y;
            Y = Convert.ToDouble(Console.ReadLine());
            double Z;
            Z = Convert.ToDouble(Console.ReadLine());
            if (X > Y && X > Z)
            {
                Console.WriteLine(X);
            }
            if (Y > X && Y > Z)
            {
                Console.WriteLine(Y);
            }
            if (Z > X && Z > Y)
            {
                Console.WriteLine(Z);
            }
        }
    }
}