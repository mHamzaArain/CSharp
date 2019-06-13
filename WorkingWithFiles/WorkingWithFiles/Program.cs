using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = System.IO.File.ReadAllText(@"C:\Users\Hamza Arain\source\repos\ReadingWrintingFile\ReadingWrintingFile\bin\Debug\Book1.txt");

            //Split string into array
            string[] lines;
            string[] no;

            lines = x.Split('\r');
            double[,] n = new double[3, 5];
            for (int i = 0; i < lines.Length ; i++)
            {
                no = lines[i].Split('\t');
                for (int j = 0; j < no.Length-1; j++)
                {
                    n[i, j] = int.Parse(no[j]);
                    Console.Write($"{n[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
