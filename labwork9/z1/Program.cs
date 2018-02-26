using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                String abs = "test1.txt";
                String a = Console.ReadLine();
                String rel = "task6175\\test" + a + ".txt";
                if (!File.Exists(rel))
                {
                    Console.WriteLine("Файл {0} не найден", Path.GetFullPath(rel));
                    return;
                }
                StreamReader str = new StreamReader(rel);
                if (!str.EndOfStream)
                {
                    String s1 = str.ReadLine();
                    Console.Write(s1);
                }
                while (!str.EndOfStream)
                {
                    String s = str.ReadLine();
                    Console.Write(",");
                    Console.Write(s);
                }

                str.Close();
            }
        }
    }
}



    

