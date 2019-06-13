using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace month
{
    class Program
    {
        static  double month(double m)
        {
            double s;
            if (m == 2)
                 s = 28;
           
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                 s = 31;
            
            else
                s = 30;
            return s;
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{month(a)}");
            Console.ReadLine();
            */

            Console.WriteLine("Enter number: ");
            float a = float.Parse(Console.ReadLine());
            int n = 1;
            while (a >= n)
            {
                if (a % n == 0)
                    Console.WriteLine("{0}", n);
                n = n + 1;
            }
            Console.ReadLine();

        }
    }
}
