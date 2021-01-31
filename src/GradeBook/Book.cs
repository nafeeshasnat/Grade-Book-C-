using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {

        public Book( string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showstate()
        {
            var result = 0.0;
            var highgrade = double.MinValue;
            var lowgrade = double.MaxValue;

            foreach(double number in grades){
                lowgrade = Math.Min(number, lowgrade);
                highgrade = Math.Max(number, highgrade);
                result += number;
            }

            var avgresult = result / grades.Count;

            System.Console.WriteLine($"The average grade is {avgresult:N2}");
            System.Console.WriteLine($"The Highest grade is {highgrade:N2}");
            System.Console.WriteLine($"The Lowest grade is {lowgrade:N2}");
        }
        private List<double> grades;        
        private string name;
    }
}