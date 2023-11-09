using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your exam score as a percentage: ");

            if (double.TryParse(Console.ReadLine(), out double examScore))
            {
               
                if (examScore >= 90)
                {
                    Console.WriteLine("Your grade: A");
                }
                else if (examScore >= 80)
                {
                    Console.WriteLine("Your grade: B");
                }
                else if (examScore >= 70)
                {
                    Console.WriteLine("Your grade: C");
                }
                else if (examScore >= 60)
                {
                    Console.WriteLine("Your grade: D");
                }
                else
                {
                    Console.WriteLine("Your grade: F");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid percentage.");

            }
            Console.ReadKey();
        }
    }
}
