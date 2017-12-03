using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            A = Convert.ToInt16(Console.ReadLine());
            int B;
            B = Convert.ToInt16(Console.ReadLine());
            if (B >= A)
                while (B >= A)
                {
                    Console.Write(A);
                    A = A + 1;
                }
            else
                while (B <= A)
                {
                    Console.Write(A);
                    A = A - 1;
                }
        }
    }
}
