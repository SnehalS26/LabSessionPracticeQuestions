using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class ArraySortAsceDesc
    {
        static void Main(string[] args)
        {
            //sort array  
            int[] arr = { 6, 5, 3, 4, 2, 1 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //if (arr[i] < arr[j])//decending
                    if (arr[i] > arr[j])//ascending order
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
