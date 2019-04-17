using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemeataryRowOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //R1
            double x1, y1, x;

            //R2
            double x2, y2, y;

            Console.WriteLine("Enter numberes in augmented form: " +
                              "\n| x1  y1 : x |" +
                              "\n| x2  y2 : y |");

            // R1
            Console.WriteLine("x1: ");
            x1 = Convert.ToDouble(Console.Read()); // 2

            Console.WriteLine("y1: ");
            y1 = Convert.ToDouble(Console.ReadLine()); // -5

            Console.WriteLine("x: ");
            x = Convert.ToDouble(Console.ReadLine()); // 3

            // R2
            Console.WriteLine("x2: ");
            x2 = Convert.ToDouble(Console.ReadLine()); // 5

            Console.WriteLine("y2: ");
            y2 = Convert.ToDouble(Console.ReadLine()); // 13

            Console.WriteLine("y: ");
            y = Convert.ToDouble(Console.ReadLine()); // 8
          

            
            // Step 1: Makng 1st element of R1 == 1 by xing by its inverse with R1.
            y2 *= (1 / x1);
            x *= (1 / x1);
            x1 *= (1 / x1);

            
            
            //Step 2: Making 1st element of R2 == 0
            //To save actual values form manupulating; x_1, y_1, _x
            double x_1, y_1, _x;
            x_1 = x1;
            y_1 = y1;
            _x = x;

            double _x2 = x2; // To save actual values form manupulating.
            if (_x2 >= 0) _x2 *= -1;

            // R1 * _x2
            x_1 *= _x2;
            y_1 *= _x2;
            _x *= _x2;

            // R1 * _x2 + R2
            x2 += x_1;
            y2 += y_1;
            y += _x;



            // Step 3: Making 2nd element of R2 == 1 by xing by its invese with R2.
            x2 *= (1 / y2);
            y *= (1 / y2);
            y2 *= (1 / y2);



            // Step 4: Making 2nd element of R1 == 0; by 
            //To save actual values form manupulating; x_2, y_2, _y
            double x_2, y_2, _y;
            x_2 = x2;
            y_2 = y2;
            _y = y;

            double _y1 = y1; // To save actual values form manupulating.
            if (_y1 >= 0) _y1 *= -1;
            else _y1 *= -1;

            // R2 * _y1
            x_2 *= _y1;
            y_2 *= _y1;
            _y *= _y1;

            // R2 * _y1 + R1
            x1 += x_2;
            y1 += y_2;
            x += _y;

            Console.WriteLine($"\n| x1  y1 : x |  =  |  {x1}   {y1}  :  {x}  |" +
                              $"\n| x2  y2 : y |  =  |  {x2}   {y2}  :  {y}  |");
            Console.ReadLine();
        }
    }
}
