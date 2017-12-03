using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            X = Convert.ToDouble(Console.ReadLine());
            double Y;
            Y= Convert.ToDouble(Console.ReadLine());
            double Z;
            Z = Convert.ToDouble(Console.ReadLine());
            if (X > -3 && X < 5)
            {
                Console.WriteLine(X);
            }
            if (Y > -3 && Y < 5)
            {
                Console.WriteLine(Y);
            }
            if (Z > -3 && Z < 5)
            {
                Console.WriteLine(Z);
            }
        }
    }
}
