using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {

            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            String a, str = Console.ReadLine();
            String[] b = str.Split(' ');
            if (P > b.Length || P < 0)
            {
                Console.WriteLine("Число P должно быть в интервале[0, размер массива)");
                return;
            }
            if (Q > b.Length || Q < 0)
            {
                Console.WriteLine("Число Q должно быть в интервале[0, размер массива)");
                return;
            }
            a = b[P];
            b[P] = b[Q];
            b[Q] = a;
            int w = 0;
            while (w < b.Length)
            {
                Console.Write(b[w] + " ");
                w++;
            }


        }
    }
}
