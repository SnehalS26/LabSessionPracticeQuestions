using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class DuckNumb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());

            int duck = 0;
            int count = 0;

            while(n>0)
            {
                duck = n % 10;
                if(duck==0)
                {
                    count++;
                }
                n = n / 10;
            }
            if(count==1)
            {
                Console.WriteLine("The number is duck");
            }
            else
            {
                Console.WriteLine("The Number is not duck");
            }
        }
    }
}
