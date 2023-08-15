using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class FascinatingNumber
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            int count = 0;
            bool check = true;
            Console.WriteLine("Enter any number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = n1 * 2;
            Console.WriteLine($"n2= {n2}");
            n3 = n1 * 3;
            Console.WriteLine($"n3 = {n3}");
            string concatestr = n1 + "" + n2 + n3;
            Console.WriteLine($"concatestr= {concatestr}");

            for (int i = 0; i < concatestr.Length; i++)
            {
                for (int j = i + 1; j < concatestr.Length; j++)
                {
                    if (concatestr[i] == concatestr[j])
                    {
                        check = false;
                        break;
                    }
                }

            }

            if (check)
            {
                Console.WriteLine($"{n1} is Fascinating number");
            }
            else
            {
                Console.WriteLine($"{n1} is not Fascinating number");
            }
        }
    }
}
