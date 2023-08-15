using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class SumOnlyEvenNumb
    {
        static void Main(string[] args)
        {
            int num = 12169962, a = 0;
            int sum = 0, count = 0;
            double avg = 0;

            //for(num= 12169962;num>0;num=num/10) another condition
            for (int i = num; i > 0; i = i / 10)
            {
                a = i % 10;
                if (a % 2 == 0)
                {
                    sum = sum + a;
                    count++;
                }
            }
            avg = sum / count;
            Console.WriteLine(avg);

        }
    }
}
