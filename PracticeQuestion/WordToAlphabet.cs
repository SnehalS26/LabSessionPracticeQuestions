using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class WordToAlphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String str = Console.ReadLine();
            string[] array = str.Split(' ');
            String str1 = " ";

            for(int i =0; i < array.Length; i++)
            {
               if(i== array.Length-1)
               {
                    str1 += array[i];
               }
               else
               {
                    char[] ch = array[i].ToCharArray();
                    for(int j = 0; j < 1; j++)
                    {
                        str1 = str1 + ch[j] + ".";
                    } 
               }
            }
            Console.WriteLine(str1);
        }
    }
}
