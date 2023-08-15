using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            //int[] arr = new int[8];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
