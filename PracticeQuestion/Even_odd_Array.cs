using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Even_odd_Array
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Enter Array Element");
            for(int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] even = new int[10];
            int[] odd = new int[10];
            int j = 0, k=0;
            for(int i=0; i< array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even[j++] = array[i];
                }
                else
                {
                    odd[k++] = array[i];
                }
            }
            Console.WriteLine("Even array-----------");
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Odd array------------");
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
