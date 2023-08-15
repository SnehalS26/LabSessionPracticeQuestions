using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lowercase to Uppercase and uppercase to lowercase 
namespace PracticeQuestion
{
    public class Case_change
    {
        static void Main(string[] args)
        {
            int i;
            String str = "Hello Good Morning";

            Console.WriteLine("------------------in-build Methods--------------------------");
            string Ucase = str.ToUpper();
            Console.WriteLine($"Uppercase String :{Ucase}");

            string Lcase = str.ToLower();
            Console.WriteLine($"LowerCase String :{Lcase}");

            Console.WriteLine("------------------------------------");
            Console.WriteLine(str);
            char[] ch = str.ToCharArray();

            for (i = 0; i < ch.Length; i++) 
            {
                if (ch[i]>='A' && ch[i]<='Z')
                {
                    ch[i] = (char)(ch[i] + 'a' - 'A');
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] + 'A' - 'a');
                }
                
            }
            Console.WriteLine(String.Join(" ",ch));
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            string s = " ";
            char[] ch1 = str1.ToCharArray();

            for(int j=0; j<ch1.Length; j++)
            {
                if (char.IsUpper(ch1[j]))
                {
                    s += char.ToLower(ch1[j]);
                }
                else if (char.IsLower(ch1[j]))
                {
                    s += char.ToUpper(ch1[j]);
                }
                else
                {
                    s += ch1[j];
                }
            }
            Console.WriteLine(" "+s);
        }
    }
}
