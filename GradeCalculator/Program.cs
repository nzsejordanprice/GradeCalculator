using System;
using System.Diagnostics;

namespace GradeCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Program display = new Program();


                int gradeDisplay = display.TotalGradeCalc();
                int gradeSwitch;

                if (gradeDisplay < 50)
                {
                    Console.WriteLine("Grade F");
                    gradeSwitch = 0;
                }
                else if ((gradeDisplay >= 50) && (gradeDisplay < 60))
                {
                    Console.WriteLine("Grade D");
                    gradeSwitch = 1;
                }
                else if ((gradeDisplay >= 60) && (gradeDisplay < 70))
                {
                    Console.WriteLine("Grade C");
                    gradeSwitch = 2;
                }
                else if ((gradeDisplay >= 70) && (gradeDisplay < 80))
                {
                    Console.WriteLine("Grade B");
                    gradeSwitch = 3;
                }
                else if (gradeDisplay >= 80)
                {
                    Console.WriteLine("Grade A");
                    gradeSwitch = 4;
                }
                else
                {
                    Console.WriteLine("Invalid Value entered, please retry");
                    gradeSwitch = 5;
                }


                display.GradeSwitchObj(gradeSwitch);
                                
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString);
                Console.ReadLine();
            }


        }
        public int TotalGradeCalc()
        {
            Console.WriteLine("Please enter the students grade for Math (out of 100): ");
            int mathGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the students grade for Physics (out of 100) : ");
            int physGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the students grade for Chemistry (out of 100) : ");
            int chemGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the students grade for Computer Science (out of 100) : ");
            int compGrade = Convert.ToInt32(Console.ReadLine());

            int totalGrade = (mathGrade + physGrade + chemGrade + compGrade) / 4;

            Console.WriteLine(totalGrade + "%");
            return totalGrade;

            
        }
        public void GradeSwitchObj(int gradeSwitch)
        {
            switch (gradeSwitch)
            {
                case 0:
                    {
                        Console.WriteLine("Fail. Your grade is F ");
                    }
                    break;

                case 1:
                    {
                        Console.WriteLine("Pass. Your grade is D");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Satisfactory. Your grade is C");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Good! Your grade is B.");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Excellent! Your grade is A");
                    }
                    break;

            }
        
        }
    }
}