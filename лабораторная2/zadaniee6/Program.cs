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
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            if (b <= 0)
                   
            {
                Console.WriteLine("Значение base должно быть положительным");
                return;
            }
                                     
            double height;
            height = Convert.ToDouble(Console.ReadLine());
            if (height <=0)
           
            {

                Console.WriteLine("Значение height должно быть положительным");
                return;
            }
            double area;
            area = b * height / 2;
            Console.WriteLine("{0:F2}", area);


            



        }
    }
}
