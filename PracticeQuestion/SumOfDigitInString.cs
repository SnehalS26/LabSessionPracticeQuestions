using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class SumOfDigitInString
    {
        public static int SumOfDigit(String str)
        {
            Console.WriteLine(str);
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    sum = sum + ((int)(char.GetNumericValue(str[i])));
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string ");
            string s = Console.ReadLine();
            int sum = SumOfDigitInString.SumOfDigit(s);

            Console.WriteLine("sum of digit=" + sum);



            /*//using without method
            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();
            
            int sum = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if(ch[i]>='0' && ch[i]<= '9')
                {
                    Console.WriteLine(ch[i]);
                    int a = (int)char.GetNumericValue(ch[i]);
                    sum = sum + a;
                }
                
            }
            Console.WriteLine(sum);
            */
        }
    }
}
