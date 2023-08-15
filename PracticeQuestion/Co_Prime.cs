using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Co_Prime
    {
        public static int CheckPrime(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int res = Co_Prime.CheckPrime(a, b);

            if (res == 1)
            {
                Console.WriteLine("Co-Prime");
            }
            else
            {
                Console.WriteLine("Not Co-PRime");
            }
        }
    }
}
