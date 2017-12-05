using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, a = -10 , B = int.Parse(Console.ReadLine());
            if (B > 10000 || B<a )
            {
                Console.WriteLine("Значение B должно быть в интервале [-10, 10000]");
            }
            else
            {
                while (a<=B )
                {
                    sum += B;
                    B--;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
