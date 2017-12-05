using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b > a)

            {
                while (b >= a)
                {
                    sum += b;
                    b--;
                }
                Console.WriteLine(sum);
            }
            else
            {
                while (b <= a)
                {
                    sum += b;
                    b++;
                }
                Console.WriteLine(sum);

            }
            }
        }
    }

