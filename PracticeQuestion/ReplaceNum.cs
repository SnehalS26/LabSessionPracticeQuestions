using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create 1 integer array and replace element by 0 which contain the digit 9
namespace PracticeQuestion
{
    public class ReplaceNum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 9, 99, 55, 6, 19 };
            int a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 10)
                {
                    a = arr[i] % 10;
                    if (a == 9)
                    {
                        arr[i] = 0;
                    }
                }

                arr[i] = arr[i] / 10;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
