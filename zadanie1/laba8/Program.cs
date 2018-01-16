using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            String [] arr;
            arr = t.Split(' ');
            Console.WriteLine(arr.Length);
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a >= arr.Length)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива");
                return;
            }
            if (String.IsNullOrWhiteSpace(t))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            Console.WriteLine(arr[a]);
        }
    }
}
