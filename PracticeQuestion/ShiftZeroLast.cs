using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class ShiftZeroLast
    {
        public static int[] ShiftLast(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)//index
            {
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[j] == 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 6, 5, 0, 0, 5, 6, 7 };
            int[] res = ShiftZeroLast.ShiftLast(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

        }
    }
}
