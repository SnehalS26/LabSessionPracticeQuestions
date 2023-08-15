using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Compare3Numb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three nos=");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("greater=" + a);
            }
            else if (b > c)
            {
                Console.WriteLine("greater =" + b);
            }
            else
                Console.WriteLine("greater =" + c);
        }
    }
}
