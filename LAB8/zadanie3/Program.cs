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
            String str = Console.ReadLine();
            String[] a = str.Split(' ');
            int b = 0;
            int c = a.Length;
            while (b < c)
            {
                Console.Write(a[c - 1] + " ");
                c--;
                    

            }
        }
    }
}
