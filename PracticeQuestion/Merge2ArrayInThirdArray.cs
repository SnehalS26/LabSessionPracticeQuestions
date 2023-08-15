using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Merge2ArrayInThirdArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 7, 2, 9, 5, 11, 1 };

            int[] arr3 = new int[arr1.Length + arr2.Length];
            /*
            int count=0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[count] = arr1[i];   
                count++;
            }
            for (int i =0 ; i < arr2.Length; i++)
            {
                arr3[count] = arr2[i];
                count++;
            }
            foreach (int item in arr3)
            {
                Console.WriteLine(arr3[item]);
            }
            */

            //Delete duplicate from arr1 and arr2 and store on arr3 
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                bool isvisited = false;
                for (int k = count - 1; k >= 0; k--)
                {
                    if (arr3[k] == arr1[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    arr3[count] = arr1[i];
                    count++;

                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {

                bool isvisit = false;
                for (int k = count - 1; k >= 0; k--)
                {
                    if (arr3[k] == arr2[i])
                    {
                        isvisit = true;
                        break;
                    }
                }
                if (isvisit == false)
                {

                    arr3[count] = arr2[i];
                    count++;
                }

            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
