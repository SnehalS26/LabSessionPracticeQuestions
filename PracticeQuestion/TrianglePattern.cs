using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class TrianglePattern
    {
        static void Main(string[] args)
        {
            /*
                A
                AB
                ABC
            */
            for (int i = 'A'; i <= 'D'; i++)
            {
                for(int j= 'A'; j <= i; j++)
                {
                    Console.Write((char)(j));
                    //Console.WriteLine((char)(j+ 64));
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

    }
}
