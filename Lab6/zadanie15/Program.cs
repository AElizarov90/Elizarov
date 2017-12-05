using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, c = 0, a = 20, b = 40;
            Console.Write("Ход Решения:0+ ");
            while (a <= b)
            {
                c = a * a * a;
                 
                Console.Write(c+ "+ " );
                sum += c;
                a++;
            }
            Console.WriteLine(" 0 =");
            Console.WriteLine(sum);
        }
    }
}
