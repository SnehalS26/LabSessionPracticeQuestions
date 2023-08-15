using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class DuplicateArray
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a sequence of numbers:");
            //string input = Console.ReadLine();

            //List<int> inputList = new List<int>();
            //foreach (char c in input)
            //{
            //    if (char.IsDigit(c))
            //    {
            //        int number = int.Parse(c.ToString());
            //        inputList.Add(number);
            //    }
            //}

            //List<int> uniqueList = new List<int>();
            //foreach (int num in inputList)
            //{
            //    if (!uniqueList.Contains(num))
            //    {
            //        uniqueList.Add(num);
            //    }
            //}

            ////Console.Write("Output: ");
            //for (int i = 0; i < uniqueList.Count; i++)
            //{
            //    Console.Write(uniqueList[i]);
            //    if (i != uniqueList.Count - 1)
            //    {
            //        Console.Write(" ");
            //    }
            //}

            //or 3-8-23
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
