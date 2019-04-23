using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total students: ");
            int totalStudent = int.Parse(Console.ReadLine()); // Total student

            string[,] studentInfo = new string[2, totalStudent]; //Row = 2 [name, Roll no.] ,col = totalStudent  
            string[] headersStudent = { "Name: ", "Roll no.: " }; //Used to asking name & roll no. 

            double[,] subjects = new double[7, totalStudent]; // Row = [eng, pst, isl, ics, cal, stats, phy], col = totalStudent
            string[] headersSubjects = {"ENG: ","PST: ", "ISL: ","ICS: ", // Used to asking subjects
                                    "CAL: ", "SDA: ", "PHY: " };

            double[,] result = new double[2, totalStudent]; //Row = [obtained marks, %], Col = totalStudent 


            // for input
            for (int i = 0; i < totalStudent; i++)  
            {
                Console.WriteLine();
                for (int j = 0; j < 2; j++) //names, roll no.
                {
                    Console.Write(headersStudent[j]);        //asking { "Name: ", "Roll no.: " }
                    studentInfo[j, i] = Console.ReadLine();  // Row = [name, roll no.] -> j, Col = totalStudent ->i
                }
                Console.WriteLine();

                for (int j = 0; j < 7; j++) //Subjects
                {
                    Console.Write(headersSubjects[j]);  //Used to asking subjects {"ENG: ","PST: ", "ISL: ","ICS: ","CAL: ", "SDA: ", "PHY: " } -> j
                    subjects[j, i] = Convert.ToDouble(Console.ReadLine()); // {"ENG: ","PST: ", "ISL: ","ICS: ","CAL: ", "SDA: ", "PHY: " } -> j, totalStudent -> i
                }
            }


            //Execution block of total marks & %
            for (int i = 0; i < totalStudent; i++)
            {
                double obtained = 0;
                for (int j = 0; j < 7; j++) // total marks
                {
                    obtained += subjects[j, i]; // Row = Subjects -> j
                }

                double percentage = (obtained / 550) * 100; // %
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) result[j, i] = obtained;   // Row = 0 -> totalMarks
                    if (j == 1) result[j, i] = percentage; // Row = 1 -> %
                }
            }


            //Dispalying data
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Write("\n\tDisplaying Data\n============================");
                for (int j = 0; j < 9; j++)
                {
                    if (j < 2)
                    {
                        Console.Write("\n" + headersStudent[j]); //displaying { "Name: ", "Roll no.: " }
                        Console.Write(studentInfo[j, i]); // Row = [name, roll no.] -> j, Col = totalStudent
                    }

                    if (j < 7)
                    {
                        Console.Write("\n" + headersSubjects[j]); // {"ENG: ","PST: ", "ISL: ","ICS: ","CAL: ", "SDA: ", "PHY: " } -> j, totalStudent -> j
                        Console.Write(subjects[j, i]);  // Row = [eng, pst, isl, ics, cal, stats, phy] -> j, col = totalStudent -> i
                    }
                }
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) Console.Write("\nObtained Marks: " + result[j, i]);    //Row = [obtained marks, %] -> j, Col = totalStudent -> i
                    if (j == 1) Console.Write("\nPercemtage: " + result[j, i] + "%");  //Row = [obtained marks, %] -> j, Col = totalStudent -> i
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}