using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class FreqWordAndEachCharString
    {
        static void FreqOfChar(string str)
        {
            char[] ch = str.ToCharArray();
            int i, j, k;
            for (i = 0; i < ch.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (k = i - 1; k >= 0; k--) //check the reverse direction
                {
                    if (ch[k] == ch[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < ch.Length; j++) //check the forword direction
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                    }
                    if (ch[i] != ' ')
                    {

                        Console.WriteLine(ch[i] + " " + count);
                    }
                }
            }
        }
        static void FreqOfWord(string s)
        {
            string[] str2 = s.Split(' ');
            int i, j, k;
            for (i = 0; i < str2.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (k = i - 1; k >= 0; k--)
                {
                    if (str2[k] == str2[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < str2.Length; j++)
                    {
                        if (str2[j] == str2[i])
                        {
                            count++;
                        }
                    }
                    if (str2[i] != " ")
                    {

                        Console.WriteLine(str2[i] + " " + count);
                    }
                }
            }
        }
       static void Main(string[] args)
       {
           string str = "I Love India";
            string s = "india is is my country";
           FreqOfChar(str);
            FreqOfWord(s);


       }    
        
    }
}
