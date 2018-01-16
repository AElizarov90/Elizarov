using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());
            String a = Console.ReadLine();
            String[] d = a.Split(' ');
            if (B < 0 || B > d.Length)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
                return;
            }
            if (E < 0 || E > d.Length)
            {
                Console.WriteLine("Число E должно быть в интервале [0, размер массива)");
                return;
            }
            if (B <= E)
            {
                while (B <= E)
                {
                    Console.Write(d[B] + " ");
                    B++;
                }
            }
            else
            {
                while (E < B)
                {
                    Console.Write(d[E] + " ");
                    E++;
                }
            }
        }
    }
}
