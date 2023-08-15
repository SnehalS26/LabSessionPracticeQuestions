using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Parent
    {
        public virtual int GetData()
        {
           return 100;
        }
    }
    public class Child : Parent
    {
        public override int GetData()
        {
            return 200;
        }
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.GetData());
            Parent p = new Child();   
            Console.WriteLine(p.GetData());
        }
    }   
}
