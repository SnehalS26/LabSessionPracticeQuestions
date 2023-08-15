using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class ToggelArray
    {
        public static char[] ToggleCase(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsUpper(ch[i]))//if(ch[i]>='A' && ch[i]<='Z')
                {
                    ch[i] = char.ToLower(ch[i]);//ch[i] = (char) (ch[i]+32)
                }
                else if (char.IsLower(ch[i]))//else if(ch[i]>='a' && ch[i]<='z')
                {
                    ch[i] = char.ToUpper(ch[i]);//ch[i] = (char) (ch[i]-32)
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
            char[] ch = new char[5];

            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.Read());
            }
            char[] ans = ToggelArray.ToggleCase(ch);

            foreach (char item in ans)
            {
                Console.Write(item);
            }
        }
    }
}
