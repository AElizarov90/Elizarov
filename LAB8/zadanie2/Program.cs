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
            String str = Console.ReadLine();
            String[] a = str.Split(' ');
            int b = 0;
            while (b < a.Length)
            {
                Console.WriteLine(a[b] + " " + b);
                b++;
            }
        }
    }
}
