using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 10, b = 20;
            while (a <= b)
            {
                if (x == a)
                {
                    Console.WriteLine(x + "+");
                    
                }
                else
                {
                    Console.WriteLine(a);
                   
                }
                a = a + 1;
            }
        }
    }
}


