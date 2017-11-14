using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            double krug, kvad;
            krug = Convert.ToDouble(Console.ReadLine());
            if (krug < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;

            }
            kvad = Convert.ToDouble(Console.ReadLine());
            if (kvad < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;

            }
            double sKvad;
            sKvad = Math.Sqrt(kvad);
            double dKvad;
            dKvad = Math.Sqrt(2 * sKvad);
            double dKrug;
            dKrug = 2 * Math.Sqrt(krug / Math.PI);

            if (dKrug < dKvad )
            {
                Console.WriteLine("Круг уместится в квадрате");
                


            }
            else if (dKvad < dKrug)
            {
                Console.WriteLine("Круг не поместится в квадрате");

            }




        }
    }
}
