using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniee6
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1;
            base1 = Convert.ToDouble(Console.ReadLine());
            double height;
            height = Convert.ToDouble(Console.ReadLine());
            double area;
            if (base1 > 0)
                            
                {


                    area = base1 * height / 2;
                    Console.WriteLine("{0:F2}", area);
                }
                else Console.WriteLine("Значение base1 должно быть положительным");
            if (height > 0)
            {
                area = base1 * height / 2;
                Console.WriteLine("{1:F2}", area);
            }


            else Console.WriteLine("Значение height должно быть положительным");
            



        }
    }
}
