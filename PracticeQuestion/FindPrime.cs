using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class FindPrime
    {
        public static bool IsPrime(int num1)
        {
            bool isprime = true;
            for (int i = 2; i < num1; i++)
            {
                if (num1 == 1)
                {
                    isprime = false;
                }
                if (num1 % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }
        static void Main(string[] args)
        {
            //Check n number of prime
            int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    bool res = FindPrime.IsPrime(i);
            //    if (res == true)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //    if (count == num)
            //    {
            //        break;
            //    }
            //}
            while (num > 0)
            {
                int digit = num % 10;
                bool res = FindPrime.IsPrime(digit);
                if (res == true)
                {
                    Console.WriteLine("prime =" + digit);
                }
                else
                {
                    Console.WriteLine("not prime =" + digit);
                }
                num /= 10;
            }
            /*
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            while (num > 0)
            {
                a = num % 10;
                num = num / 10;
                int count = 0;

                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        count = 1; //or count++
                        break;
                    }

                }
                if (count == 0)
                {
                    Console.WriteLine("prime " + a);
                }
            }
            */
        }
    }
}
