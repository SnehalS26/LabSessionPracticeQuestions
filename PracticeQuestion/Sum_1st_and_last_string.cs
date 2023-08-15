using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to take 1 string from user which contain number calculate the first three digit sum and last three digit sum if both the sm are same then display valid string
//otherwise throw constom exception

namespace PracticeQuestion
{
    public class Sum_1st_and_last_string
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            int sum = 0;
            bool flag = true;
            //while(str.Length>=3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] >= 'Z')
                    {
                        flag = false;
                        break;
                    }
                    else if (str[i] >= '0' && str[i] <= '9')
                    {
                        sum = sum + ((int)(char.GetNumericValue(str[i])));
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
