using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //to calculate the power of number

            int basenumber = 3;
            int expo = 4;//index or exponant
            int power = 1;

            for (int i = 1; i <= expo; i++)
            {
                power = power * basenumber;
            }
            Console.WriteLine(power);

            //convert binary no to decimal no
            int num = 1101; //op = 13
            int sum = 0;
            int index = 0;//index

            while (num > 0)
            {
                int digit = num % 10;

                for (int i = 1; i <= index; i++)
                {
                    power = power * 2;
                }
                int ans = power * digit;
                sum = sum + ans;

                num = num / 10;
                index++;
            }
            Console.WriteLine(sum);
        }
    }
}
