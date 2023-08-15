using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    internal class Krishnamurthy
    {
        static void Main(string[] args)
        {
            int i, numb, sum = 0, fact = 1;
            Console.WriteLine("Enter number");
            numb = Convert.ToInt32(Console.ReadLine());
            int temp = numb;
            while (numb > 0)
            {
                int digit = numb % 10;

                for (i = 1; i < numb; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;

                numb = numb / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine("krishnmurthy no" + sum);
            }
            else
            {
                Console.WriteLine("NotKrishnmurthy no" + sum);
            }
        } 
    }
}
