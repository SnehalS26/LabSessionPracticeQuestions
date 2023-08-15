using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class SpyNumb
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int a = 0, sum = 0, prod = 1;
            int temp = num;
            while (num > 0)
            {
                a = num % 10;
                sum = sum + a;
                prod = prod * a;
                num = num / 10;
            }
            if (sum == prod)
            {
                Console.WriteLine("spy no=" + temp);
            }
        }
    }
}
