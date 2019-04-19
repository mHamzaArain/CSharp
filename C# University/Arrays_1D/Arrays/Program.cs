using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double[] inquary;          // Declaring arary
            inquary = new double[10];  // Init array

            double[] balance = new double[10]; //Declaring + init array

            //Assiging element in array by using index

            balance[0] = 4; 

            //Assingn values at the iof init

            int[] num = new int[5] { 99, 98, 92, 97, 95 };

            // Omit elements of array at the time of init

            float[] n = new float[] { 99, 98, 92, 97, 95 };

            // You can copy an array variable into another target array variable.
            //In such case, both the target and source point to the same memory location −

            double variable = new double[] { 99, 98, 92, 97, 95 };
            double var = variable;   // Copying above array.

            */

            Console.WriteLine("How many students that you eant to enter their result?");
            int total = int.Parse(Console.ReadLine());

            //Making array that keeps track of student

            string[] student = new string[total]; //declaring & init array.

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nStudent whose serial no.{i+1}");
                student[i] = Console.ReadLine();
            }

            //For statistics

            float[] statistics = new float[total]; //declaring & init array.
            Console.WriteLine("\nStatistics: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                statistics[i] = float.Parse(Console.ReadLine());
            }

            //For Pst

            float[] pst = new float[total];  //declaring & init array.
            Console.WriteLine("\nPakistan Studies: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                pst[i] = float.Parse(Console.ReadLine());
            }

            //For islamiyat

            float[] isl = new float[total];  //declaring & init array.
            Console.WriteLine("\nIslamic Studies: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                isl[i] = float.Parse(Console.ReadLine());
            }

            //For ics

            float[] ics = new float[total];  //declaring & init array.
            Console.WriteLine("\nIntroduction to Computer Science: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                ics[i] = float.Parse(Console.ReadLine());
            }

            //For physics

            float[] phy = new float[total];  //declaring & init array.
            Console.WriteLine("\nPhysics: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                phy[i] = float.Parse(Console.ReadLine());
            }

            //For english

            float[] eng = new float[total];  //declaring & init array.
            Console.WriteLine("\nEnglish: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                eng[i] = float.Parse(Console.ReadLine());
            }

            //For cal

            float[] cal = new float[total];  //declaring & init array.
            Console.WriteLine("\nCalculus: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nEnter marks of student: {student[i].ToUpper()}");
                cal[i] = float.Parse(Console.ReadLine());
            }



            //For obtained marks.

            float[] obt = new float[total];  //declaring & init array.
            Console.WriteLine("\nIntroduction to Computer Science: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nStudent: {student[i].ToUpper()}");
                obt[i] = (statistics[i] + pst[i] + isl[i] + ics[i] + phy[i]) + cal[i] + eng[i]; // obt marks.
            }

            //For GPA.

            float[] gpa  = new float[total];  //declaring & init array.
            Console.WriteLine("\nIntroduction to Computer Science: ");

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine($"\nStudent: {student[i].ToUpper()}");
                /* English = 50
                 * pst = 50
                 * phy = 100
                 * cal = 100
                 * ics = 100
                 * ststs = 100
                 * GPA = obt/total * 5 = obt/500 * 5  */

                gpa[i] = (obt[i]/500)*5; // obt mark
            }
            int j = 0;
            //To show all result
            foreach (int f in gpa)
            {
                Console.WriteLine("\nStudent: " + student[j].ToUpper() +
                                   "\n============================" +
                                   "\nStatistics: " + statistics[j] +
                                   "\nPhysics:  " + phy[j] +
                                   "\nEnglish: " + eng[j] +
                                   "\nIslamiyat: " + isl[j] +
                                   "\nPakistan Studies: " + pst[j] +
                                   "\nCalculus: " + cal[j] +
                                   "\n==============================" +
                                   "\nObtained marks: " + obt[j] +
                                   "\n==============================" +
                                   "\nGPA: " + gpa[j]);
                j++;
            }
            Console.ReadLine();
        }
    }
}