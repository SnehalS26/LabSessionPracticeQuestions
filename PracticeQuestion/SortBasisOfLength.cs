using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class SortBasisOfLength
    {
        static void Main(string[] args)
        {
            //sort the string by length
            string str = "India is my best Country";
            //Console.WriteLine(str);
            string[] array = str.Split(' ');

            for (int i=0; i <array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    
                }
                Console.WriteLine(array[i]);
            }

            //sort the string by same length i.e is,my
            //op--my is India Country  or  is my India Country

            /*
             string str = "India is my Country";

            string[] str1 = str.Split();
            string temp = "";

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i + 1; j < str1.Length; j++)
                {
                    if (str1[i].Length > str1[j].Length)
                    {
                        temp = str1[i];
                        str1[i] = str1[j];
                        str1[j] = temp;
                    }
                    else if(str1[i].Length == str1[j].Length)
                    {
                        int x = str1[i].CompareTo(str1[j]);
                        if(x<1)
                        {
                            string temp2 = str1[i];
                            str1[i] = str1[j];
                            str1[j] = temp2;
                        }
                    }
                }
            }
            foreach (string item in str1)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
