using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону C:");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int e = 0;
            while (a >= c)
            {
                a -= c;
                d++; 
            }
            Console.WriteLine(d);
            while (b >= c)
            {
                b -= c;
                e++; 
            }
            Console.WriteLine(e);
            int count = 0;
            for (int i = 0; i < d; i++)
                count += e;
            Console.WriteLine("N= " + count);
            Console.ReadKey();
        }
    }
}
