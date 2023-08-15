using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class DecimalToBinary
    {
        static void Main(string[] args)
        {
            //to calculate the power of number

            int basenumber = 3;
            int expo = 4;//index or exponant
            int power = 1;
            int i;

            for ( i = 1; i <= expo; i++)
            {
                power = power * basenumber;
            }
            Console.WriteLine(power);

            //convert decimal to binary
            Console.Write("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());
            
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.WriteLine();
        }
    }
}
