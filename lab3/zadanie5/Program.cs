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
            double distanceInKm;
            distanceInKm = Convert.ToDouble(Console.ReadLine());
            if (distanceInKm < 0)
            {
                Console.WriteLine("Значение distanceInKm должно быть неотрицательным");
                    return;
                    
            }
            double distanceInFeet;
            distanceInFeet = Convert.ToDouble(Console.ReadLine());
            if (distanceInFeet < 0)
            {
                Console.WriteLine("Значение distanceInFeet должно быть неотрицательным");
                return;
            }
             double R;
            R = distanceInKm * 0.305* 0.305* 0.305;
            if (R < distanceInFeet)
            {
                Console.WriteLine("Расстояние в километрах меньше");

            }
            else if (R > distanceInFeet)
            {
                Console.WriteLine("Расстояние в футах меньше");
            
            

            }
            

            

        }
    }
}
