using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum1 = 0;
            int sum2 = 0;
            int n;
            do
            {
                Console.WriteLine("Введите число");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    sum1++;
                else if (n < 0)
                    sum2++;
            } 
            while (n!=0);
            Console.WriteLine("Число положительных {0}, Число отрицательных {1}", sum1,sum2);
            Console.ReadKey();
        }
    }
}
