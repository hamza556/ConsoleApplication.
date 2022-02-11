using System;

namespace ConsoleApplicatotask
{
    class Program
    {
        static void Main(string[] args)
        {
           //Code to creat a CGPA calculator
            string[] courses;
            courses = new string[4] { "Math", "Science" ,"Computer", "English" };
            double[] score = { 0, 0, 0, 0 };
            double sum = 0;
            char grade = 'F';
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter your"+ courses[i] + " Score , and then press Enter");
                score[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + score[i];
            }
             //  Calculate the average 
            double avg = sum / 4;

            if (avg >= 90)
            {
                grade = 'A';
            }
            else
            {
                if (avg >= 80 && avg <= 89)
                {
                    grade = 'B';
                }
                else
                {
                    if (avg >= 70 && avg <= 79)
                    {
                        grade = 'C';
                    }
                    else
                    {
                        if (avg >= 60 && avg <= 69)
                        {
                            grade = 'D';
                        }
                        else
                        {
                            if (avg < 60)
                            {
                                grade = 'F';
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Your grade is  " + (grade) + "  with" + (avg) + "% score"  );
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the CGPA  Calculator console app...");
            Console.ReadKey();
        }
    }
}
