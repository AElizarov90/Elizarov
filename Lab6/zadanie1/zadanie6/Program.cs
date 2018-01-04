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
            int A;
            A = Convert.ToInt16(Console.ReadLine());
            int B;
            B = Convert.ToInt16(Console.ReadLine());
            if (A<B)
                while (A <= B)
                {
                    Console.Write(A);
                    A = A + 1;
                }
            else
            while (A>=B)
            {
                Console.Write(B);
                B = B + 1;
            }
            
        }
    }
}
