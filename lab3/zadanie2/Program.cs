using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int P;
            P = Convert.ToInt32(Console.ReadLine());
            int Q;
            Q = Convert.ToInt32(Console.ReadLine());
            if (P > Q)
            {
                Console.WriteLine("максимальное {0}, минимальное {1}", P, Q);
            }
            else
            { Console.WriteLine("максимальное {1}, минимальное {0}", P, Q); }
        



    }
    }
}
