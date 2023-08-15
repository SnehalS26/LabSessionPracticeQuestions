using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class DisariumNumb
    {
        static void Main(string[] args)
        {
            int n , digit;
            int sum=0,  count = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;

            while(n > 0) // calculate length
            {
                count++;
                n = n / 10;
            }
            n = temp;
            while(n > 0)
            {
                int pow = 1;
                digit = n % 10;
                
                for(int i = 1; i <= count; i++) 
                {
                    pow = pow * digit;
                }
                sum = sum + pow;
                count --;
                n = n / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine("The number is Disarium Number");
            }
            else
            {
                Console.WriteLine("The number is not Disarium Number");
            }

        }
    }
}
