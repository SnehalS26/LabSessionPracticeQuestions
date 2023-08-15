using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class CheckDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of week=");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("1.Monday weekday");
                    break;

                case 2:
                    Console.WriteLine("2.tuesday weekday");
                    break;

                case 3:
                    Console.WriteLine("3.wednsday weekday");
                    break;

                case 4:
                    Console.WriteLine("4.thursday weekday");
                    break;

                case 5:
                    Console.WriteLine("5.friday weekday");
                    break;

                case 6:
                    Console.WriteLine("6.saturday weekend");
                    break;

                case 7:
                    Console.WriteLine("7.sunday weekend");
                    break;

                default:
                    Console.WriteLine("invalid entry");
                    break;

            }


            //OR

            //Console.WriteLine("Enter a day of week=");
            //int num = int.Parse(Console.ReadLine());

            //if(num >= 1 && num<=5)
            //{
            //    Console.WriteLine("weekday "+num);
            //}
            //else
            //{
            //    Console.WriteLine("weekend "+num);
            //}

        }
    }
}
