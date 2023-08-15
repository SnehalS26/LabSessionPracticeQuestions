using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class EmployeeContentment
    {
        int empid;
        string ename;
        public EmployeeContentment(int empid,string ename) 
        {
            this.empid = empid;
            this.ename = ename;
        }
        public override string ToString()
        {
            return empid + " " + ename;
        }
        static void Main(string[] args)
        {
            Department[] d = new Department[3];
            d[0] = new Department(101, "HR", new EmployeeContentment(1, "Snehal"));
            d[1] = new Department(102, "Manager", new EmployeeContentment(2, "Nikita"));
            d[2] = new Department(103, "Admin", new EmployeeContentment(3, "Neha"));

            foreach (Department de in d)
            {
                Console.WriteLine(de);
            }
            List <Department> list = new List<Department>();
            list.Add(new Department(104, "Admin", new EmployeeContentment(4, "Vedant")));
            list.Add(new Department(105, "Admin", new EmployeeContentment(5, "Vedanti")));
            list.Add(new Department(106, "Admin", new EmployeeContentment(6, "Swapnil")));

            foreach(Department de in list)
            {
                Console.WriteLine(de);
            }
        }

    }

    public class Department
    {
        int did;
        string dname;
        EmployeeContentment emp;

        public Department(int did, string dname, EmployeeContentment emp)
        {
           this.did = did;
            this.dname = dname;
            this.emp = emp;
        }
        public override string ToString()
        {
            return did + " " + dname + " " + emp;
        }

    }

}
