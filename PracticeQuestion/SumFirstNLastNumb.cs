using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class SumFirstNLastNumb
    {
        static void Main(string[] args)
        {
            int num, first = 0, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            int last = num % 10;

            while (num > 0)
            {
                first = num % 10;
                num /= 10;
            }
            sum = first + last;
            Console.WriteLine(sum);
        }
    }
}
