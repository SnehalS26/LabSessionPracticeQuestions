using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class FreqNumber
    {
        static void Main(string[] args)
        {
            // from number to find frequency
            // int num = 1223447;
            Console.WriteLine("Enter a numbers=");
            int num = int.Parse(Console.ReadLine());
            int temp = num;

            for (int i = 0; i <= 9; i++)
            {
                int count = 0;
                while (num > 0)
                {
                    int digit = num % 10;

                    if (digit == i)
                    {
                        count++;
                    }
                    num = num / 10;
                }

                num = temp;
                if (count != 0)
                {
                    Console.WriteLine(i + " frequency times " + count);
                }
            }
        }
    }
}
