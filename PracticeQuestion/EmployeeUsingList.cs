using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class EmployeeUsingList
    {
        public int empid;
        public string name;
        public double Salary;

        public EmployeeUsingList(int empid, string name, int Salary)
        {
            this.empid = empid;
            this.name = name;
            this.Salary = Salary;
        }
        static void CheckSalary(List<EmployeeUsingList> list) 
        {
            Console.WriteLine("check Salary greater than 20k");
            foreach (EmployeeUsingList emp in list)
            {
                if (emp.Salary>20000)
                {
                    Console.WriteLine($"{emp.empid} {emp.name} {emp.Salary}");

                }
            }
        }
        static void IncreaseSalary(List<EmployeeUsingList> lists)
        {
            Console.WriteLine("Salary less than 20k salary incresed 10%");
            foreach ( EmployeeUsingList emp in lists)
            {
                if(emp.Salary< 20000)
                {
                    emp.Salary += emp.Salary * 0.10;
                    Console.WriteLine($"{emp.empid} {emp.name} {emp.Salary}");
                }
            }
        }
        



        static void Main(string[] args)
        {
            List<EmployeeUsingList> emp = new List<EmployeeUsingList>();
            emp.Add(new EmployeeUsingList(1, "Snehal", 1000));
            emp.Add(new EmployeeUsingList(2, "Swapnil", 20000));
            emp.Add(new EmployeeUsingList(3, "Nikita", 25000));
            emp.Add(new EmployeeUsingList(4, "Siddhi", 35000));
            emp.Add(new EmployeeUsingList(5, "Neha", 25000));
            emp.Add(new EmployeeUsingList(6, "Anjali", 1000));

            foreach (EmployeeUsingList employee in emp)
            {
                Console.WriteLine($"{employee.empid} {employee.name} {employee.Salary}");
            }
            Console.WriteLine();
            CheckSalary(emp);
            Console.WriteLine();
            IncreaseSalary(emp);

           
            List<String> list = new List<string>();
            Dictionary<double, List<string>> emp1= new Dictionary<double, List<string>>();

            foreach(EmployeeUsingList item in emp)
            {
                if (emp1.ContainsKey(item.Salary))
                {
                    list = emp1[item.Salary];
                    list.Add(item.name);
                }
                else
                {
                    list = new List<String>();
                    list.Add(item.name);
                }
                if (!emp1.ContainsKey(item.Salary))
                    emp1.Add(item.Salary, list);

            }

            foreach(KeyValuePair<double, List<string>> item in emp1)
            {
                List<String> li = item.Value;

                Console.Write(item.Key + " ");
                foreach (String str in li)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();

            }

        }
    }
    
}
