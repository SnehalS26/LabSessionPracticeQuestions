using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class DivisibleBy3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int a = 0;

            //while (num > 0)
            //{
            //    a = num % 10;
            //    num = num / 10;
            //    if (a%3 == 0)
            //    {
            //        Console.WriteLine("Divisible by three "+a);
            //    }
            ////Write a program to input a number and check if it’s a multiple of 5.
            
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 5 == 0)
            {
                Console.WriteLine("Divisible by 5 =" + n);
            }
            else
            {
                Console.WriteLine("Not Divisible by 5= " + n);
            }
        }
    }
}
