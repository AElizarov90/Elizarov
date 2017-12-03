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
            String x= Console.ReadLine();
            switch (x)
            {
                case "a": Console.WriteLine("a+\nb\nc\nd\ne\nf\ng\nh");
                    break;
                case "d": Console.WriteLine("a\nb\nc\nd+\ne\nf\ng\nh");
                    break;
                case "h": Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh+");
                    break;
                case "i": Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh");
                    break;
            }
            

        }
    }
}
