using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//find the frequency of list 
namespace PracticeQuestion
{
    public class StringFeqUsingList
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Red");
            list.Add("Yellow");
            list.Add("Green");
            list.Add("Red");
            list.Add("Green"); 
            list.Add("Red");

          for(int i=0; i<list.Count; i++)
            {
                int Count = 1;
                for(int j= i + 1; j<list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        Count++;
                        list.RemoveAt(j);
                    }
                }
                Console.WriteLine(list[i] + " " + Count);
            }

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> pair in keyValuePairs)
            {
                Console.WriteLine($"{pair.Key}:{pair.Value}");
            }
        }
    }
}
