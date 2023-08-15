using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Search element in array
//Display Alternate elements from array
namespace PracticeQuestion
{
    public class SearchElement
    {
        static int index;
        public static bool SearchNo(int[] n, int num)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == num)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        public static void DisplayAlternate(int[] s)
        {
            for (int i = 0; i < s.Length; i = i + 2)
            {

                Console.WriteLine(s[i] + " ");

            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 55, 555, 4, 65, 22 };

            //Console.WriteLine("Enter a no");
            //int num = Convert.ToInt32(Console.ReadLine());

            /*
            bool result = SearchElement.SearchNo(arr, num);

            if (result == true)
            {
                Console.WriteLine("present =" + index);
            }
            else
                Console.WriteLine("not found");           
            */

            //alternate numbers
            SearchElement.DisplayAlternate(arr1);
        }
    }
}
