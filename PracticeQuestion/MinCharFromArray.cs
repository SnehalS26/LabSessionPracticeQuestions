using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class MinCharFromArray
    {
        public static char MinChar(char[] c)
        {
            char min = c[0];
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] < min)
                {
                    min = c[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            char[] ch = { 'c', 'D', 'a', 'e', 'O' };

            char a = MinCharFromArray.MinChar(ch);
            Console.WriteLine(a);
        }
    }
}
