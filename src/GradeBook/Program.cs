using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {  
            var book = new Book("Rafin's Grade Book"); 
            book.AddGrade(98.4);
            book.AddGrade(80.4);
            book.AddGrade(85.3);

            book.showstate();

            
        }
    }
}