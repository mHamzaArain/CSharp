using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        class MyCalculator
        {
            public static void displayMenu()
            {
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = Menu();
                }
            }
            public bool Menu()
            {
                Console.Clear();
                Console.WriteLine("\tCalculator");
                Console.WriteLine("Choose any of these options o peform: ");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Substraction");
                Console.WriteLine("3) Multiplication");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Squaer root");
                Console.WriteLine("6) Power of x");
                Console.WriteLine("Press Any keywrod to close Program.... ");
                MyCalculator cls = new MyCalculator();
                string chosenOption = Console.ReadLine();

                switch (chosenOption)
                {
                    case "1":
                        Console.Clear();
                        cls.Addition();
                        return true;

                    case "2":
                        Console.Clear();
                        cls.Substractions();
                        return true;

                    case "3":
                        Console.Clear();
                        cls.Multiplicaion();
                        return true;

                    case "4":
                        Console.Clear();
                        cls.Division();
                        return true;

                    case "5":
                        Console.Clear();
                        cls.SqrtRoot();
                        return true;

                    case "6":
                        Console.Clear();
                        cls.Power();
                        return true;

                    default:
                        return false;

                }

            }
            public void Addition()
            {
                Console.WriteLine("Give numbers to pefom addition sepaated by single space: ");
                string add = Console.ReadLine();
                var splitedAdder = add.Split(' ');
                float sum = 0;
                foreach (string item in splitedAdder)
                {
                    sum += Int32.Parse(item);
                }
                Console.WriteLine(String.Format("Total sum: {0}", sum));
                Console.ReadLine();
            }
            public void Substractions()
            {
                Console.WriteLine("Give numbers to pefom substaction sepaated by single space: ");
                string minus = Console.ReadLine();
                minus = "-" + minus;
                var splitedMinus = minus.Split(' ');
                float min = 0;
                foreach (string item in splitedMinus)
                {
                    min -=  Int32.Parse(item);
                }
                Console.WriteLine(String.Format("Substacted value: {0}", min));
                Console.ReadLine();
            }
            public void Multiplicaion()
            {
                Console.WriteLine("Give numbers to pefom multiplication sepaated by single space: ");
                string mul = Console.ReadLine();
                var splitedMultiplier = mul.Split(' ');
                float muliple = 1;
                foreach (string item in splitedMultiplier)
                {
                    muliple *= Int32.Parse(item);
                }
                Console.WriteLine(String.Format("MUltiplication: {0}", muliple));
                Console.ReadLine();
            }
            public void Division()
            {
                Console.WriteLine("Give numbers to pefom division sepaated by single space: ");
                string div = Console.ReadLine();
                var splitedDivider = div.Split(' ');
                float divide = 1;
                foreach (string item in splitedDivider)
                {
                    divide =  Int32.Parse(item) / divide;
                }
                Console.WriteLine(String.Format("Total sum: {0}", divide));
                Console.ReadLine();
            }
            public void SqrtRoot()
            {
                Console.WriteLine("Enter number to get sqr root: ");
                double sqt = double.Parse(Console.ReadLine());

                double sqrt = Math.Sqrt(sqt);
                Console.WriteLine(String.Format("Square Root: {0}", sqrt));
                Console.ReadLine();
            }
            public void Power()
            {
                Console.WriteLine("X^power");
                Console.Write("X: ");
                double X = double.Parse(Console.ReadLine());
                Console.Write("Power: ");
                double power = double.Parse(Console.ReadLine());

                double result = Math.Pow(X, power);
                Console.WriteLine(String.Format("Power: {0}", result));
                Console.ReadLine();
            }
            
        }
        static void Main(string[] args)
        {
            MyCalculator cal = new MyCalculator();
            cal.displayMenu();
        }
    }
}
