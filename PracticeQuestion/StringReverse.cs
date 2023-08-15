using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class StringReverse
    {
        static void Main(string[] args)
        {
            //input--> india is my country
            //output-->aidni si ym yrtnuoc

            String str = "india is my country";
            string[] array = str.Split(' ');
            String reversevalue = " ";

            for(int i = 0; i < array.Length ; i++)
            {
                string word = array[i];
                string reverseword = " ";
                
                    
                for(int j = word.Length - 1; j >= 0 ; j--)
                {
                    reverseword += word[j];
                }

               reversevalue += reverseword;
            }
            Console.WriteLine($"First String is:{reversevalue}");



            //input--> india is my country
            //output--> india si ym country
            int m,n;
            String str1 = "india is my country";
            string[] array1 = str.Split(' ');
            String reversevalue1 = " ";

            for( m=0; m < array1.Length ; m++)
            {

                if(m == 0 || m==array.Length-1)
                {
                    reversevalue1 += array1[m];
                }
                else
                {
                    string word1 = array1[m];
                    string reverseword1 = " ";

                    for(n=word1.Length - 1;n >= 0 ; n--)
                    {
                        reverseword1 += word1[n];
                    }
                    reversevalue1 += reverseword1;
                }
            }
            Console.WriteLine($"Second String is :{reversevalue1}");

        }
    }
}
