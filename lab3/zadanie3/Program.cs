using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            K = Convert.ToInt32(Console.ReadLine());
            if (K >= 0)
            {
                Console.WriteLine(Math.Sqrt(K));

            }
            else
            {
                Console.WriteLine(K * K);
            }
        }
    }
}
