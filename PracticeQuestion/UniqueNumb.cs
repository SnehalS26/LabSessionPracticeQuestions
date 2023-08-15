using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class UniqueNumb
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 2, 3, 4, 5, 9, 8, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    //if(count == 1) for unique no 
                    if (count > 1) // for duplicate no
                    {
                        Console.WriteLine(arr[i] + " " + count);
                    }
                }
            }
        }
    }
}
