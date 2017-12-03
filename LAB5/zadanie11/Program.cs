using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b )
            {
                Console.WriteLine("\"Выполняется\"");

            }
            else
            {
                Console.WriteLine("\"Не выполняется\"");
            }
        }
        
    }
}
