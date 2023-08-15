using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class DuplicateNumb
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Enter Array Element");
            int[] arr = new int[5];

            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<arr.Length;i++)
            {
                count = 1;
                bool isvisted = false;

                for(int k=i-1;k>=0;k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisted = true;
                        break;
                    }
                }
                if (isvisted == false)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        if (arr[j] == arr[i])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + "-" +count);
                }
            }
        }
    }
}
