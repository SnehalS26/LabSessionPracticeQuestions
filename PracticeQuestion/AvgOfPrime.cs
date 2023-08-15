using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class AvgOfPrime
    {
        static bool CheckPrime(int n)
        {
            if (n < 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0, sum = 0;
            double avg = 0;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (CheckPrime(digit))
                {
                    Console.WriteLine("Prime is =" + digit);
                    sum += digit;
                    count++;
                }
                temp /= 10;
            }
            avg = sum / count;
            Console.WriteLine("\n\nAverage of Prime =" + avg);
        }
    }
}
