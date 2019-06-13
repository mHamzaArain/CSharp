
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearh
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] list = {1, 3.5, 67, 89, 34, 7};
            double target = 3.5;

            //LinearSearch(list, target);
            Console.WriteLine(LinearSearch(list, target));
            Console.ReadLine();
        }

        public static int LinearSearch(double[] list, double target) 
        {
            // Compareeah value by target
            int index = 0;
            foreach (var item in list)
            {
                if (item == target)
                {
                    break;
                }
                index++;
            }
            return index;
        }
    }
}
