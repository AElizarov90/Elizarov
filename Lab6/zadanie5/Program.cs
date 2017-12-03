using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1, B;
            a1 = Console.ReadLine();
            B = Console.ReadLine();
            int A;
            A = int.Parse(a1);
            if (A < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            int C = 0;
            Console.Write("\"");
            while (C < A)
            {
                Console.Write(B);
                C = C + 1;
            }
            Console.Write("\"");
        }
    }
}