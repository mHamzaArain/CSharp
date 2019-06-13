using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingWrintingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 12, c = 9, d = 137;
            string s = "";
            
            //Converting int to String
            s += a.ToString() + ", "; 
            s += b.ToString() + ", ";
            s += c.ToString() + ", ";
            s += d.ToString();

            Console.WriteLine(s);
            Console.ReadLine();

            System.IO.File.AppendAllText("arshia.txt", s);
            Console.ReadLine();
        }
    }
}
