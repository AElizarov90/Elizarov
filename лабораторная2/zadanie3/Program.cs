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
            double edge;
            edge = Convert.ToDouble(Console.ReadLine());
            double volume;
            if (edge > 0)
            {
                volume = edge * edge * edge;
                Console.WriteLine(volume);
            }
            else
                Console.WriteLine("Значение edge должно быть положительным");
        }
    }
}
