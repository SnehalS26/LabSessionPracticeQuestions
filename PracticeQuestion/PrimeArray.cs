using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class PrimeArray
    {
        public static bool CheckPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //int[] arr = {151,95,83,56,99,1001 };

            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            int count = 0;
            double avg = 0;
            Console.WriteLine("------------------------------");
            foreach (int num in arr)
            {
                if (CheckPrime(num))
                {
                    count++;
                    Console.WriteLine("Prime no is =" + num);
                    sum += num;

                }
            }
            Console.WriteLine("--------------------------------------");

            if (count > 0)
            {
                avg = sum / count;
                Console.WriteLine("Prime average =" + avg);
            }


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num=arr[i];

            //    if(CheckPrime(num))
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}


            //with using count method
            /*
            int sum = 0;
            int count = 0;
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 2; j <arr[i] ; j++)
                {
                    if (arr[i] % j == 0 )
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("prime no =" + arr[i]);
                }
                */
        }
    }
}
