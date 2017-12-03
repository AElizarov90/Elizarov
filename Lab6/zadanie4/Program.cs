using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            A = Convert.ToInt16(Console.ReadLine());
            int B;
            B = Convert.ToInt16(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
                return;

            }
            if (A>=B)
            while (B >= A)
            {
                Console.Write(A);
                A = A + 1;
            }

            else 
            while (B <= A)
            {
                Console.Write(B);
                A = A+ 1;
            }
        }
    }
}
