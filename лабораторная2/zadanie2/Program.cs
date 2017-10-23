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
            int edge;
            edge = Convert.ToInt16(Console.ReadLine());
            int area;
            if (edge > 0)
            {
                area = 6 * edge * edge;
                Console.WriteLine(area);
            }
            else Console.WriteLine("Значение edge должно быть положительным");

        }
    }
}
