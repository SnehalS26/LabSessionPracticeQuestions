using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class SortHalfAsceNHaldDesc
    {
        
        static void Main(string[] args)
        {
            int temp;
            int[] arr = { 3, 4, 2, 10, 14, 13 , 1, 30 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i< arr.Length / 2; i++ ) //ascending
            {
                Console.WriteLine(arr[i]);
            }
            for(int j= arr.Length-1; j>= arr.Length/2; j-- ) //descending
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
