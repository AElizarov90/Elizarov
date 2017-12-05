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
        {   long sum = 1, a = long.Parse(Console.ReadLine()), b = long.Parse(Console.ReadLine());
            
            if (b > a)

            {
                while (b >= a)
                {
                    sum *= b;
                    b--;
                }
                Console.WriteLine(sum);
            }
            else
            {
                while (b <= a)
                {
                    sum *= b;
                    b++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
