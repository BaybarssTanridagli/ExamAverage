using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double exam1, exam2, exam3, average;
            Console.WriteLine("Please Enter The Exam1: ");
            exam1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Exam2: ");
            exam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Exam3: ");
            exam3 = Convert.ToDouble(Console.ReadLine());
            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Average: ",average);

            if (average >= 50)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
            Console.ReadKey();


        }
    }
}
