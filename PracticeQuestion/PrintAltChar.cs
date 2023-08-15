using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class PrintAltChar
    {
        public static char[] AlternateChar(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'X')
                {
                    ch[i] = (char)(ch[i] + 2);
                }
                else if (ch[i] >= 'a' && ch[i] <= 'x')
                {
                    ch[i] = (char)(ch[i] + 2);
                }
                else if (ch[i] == 'Y')
                {
                    ch[i] = (char)(ch[i] - 24);
                }
                else if (ch[i] == 'Z')
                {
                    ch[i] = (char)(ch[i] + 8);
                }
                else
                {
                    ch[i] = ch[i];
                }
            }

            return ch;
        }
        static void Main(string[] args)
        {
            char[] ch = { 'p', 'A', 'r', 'Y', 'Z' };//Z-->b

            //for (int i = 0; i < ch.Length; i++)
            //{
            //    ch[i] = Convert.ToChar(Console.Read());
            //}

            char[] ans = PrintAltChar.AlternateChar(ch);

            foreach (char item in ans)
            {
                Console.Write(item);
            }
        }
    }
}
