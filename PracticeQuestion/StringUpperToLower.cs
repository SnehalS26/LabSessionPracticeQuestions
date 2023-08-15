using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//convert string into upper or lower (toggle case)
namespace PracticeQuestion
{
    public class StringUpperToLower
    {
        static void Main(string[] args)
        {

          string str = Console.ReadLine();
            string str1 = "";
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                {
                    str1 = str1 + char.ToLower(ch[i]);
                }
                else if (char.IsLower(ch[i]))
                {
                    str1 = str1 + char.ToUpper(ch[i]);
                }
                else
                {
                    str1 = str1 + ch[i];
                }
            }
            Console.WriteLine(str1);
        }
    }
}
