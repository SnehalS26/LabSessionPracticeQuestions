using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class CharPattern
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 0; i--)//edcba  //dcba  cba   ba 
            {
                char c = 'e';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c);
                    c--;
                }
                Console.WriteLine("\n");
            }

            //or
            //for (char i = 'A'; i <'G' ; i++)
            //{
            //    for (char j = 'A' ; j <=i ; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine("\n");
            //}

            //or in intger
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write((char)(j+64));
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
