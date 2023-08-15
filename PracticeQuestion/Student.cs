using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create student class stud has id name and 3 sub marks create method to accept stud details , create calculate perc on the basis of marks
//create method to calculate the grade as per the percentage and create method to display all the details of id name 3 subj marks and perce
namespace PracticeQuestion
{
    public class Student
    {
        int id, perc , total , marks;
        string name;
        int m1, m2, m3;

        public void AcceptStudDeatils(int  id , string name, int m1, int m2, int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void CalculatePercentage()
        {
            total = m1 + m2 + m3;
            perc = total / 3;
            ShowDetails();
        }
        public void Grade()
        {
            if(perc >=90)
            {
                Console.WriteLine("Grade is A+");
            }
            else if(perc >=80 && perc < 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if(perc >=70 && perc < 80)
            {
                Console.WriteLine("Grade is B");
            }
            else if(perc >= 60 && perc < 70)
            {
                Console.WriteLine("Grade is C");
            }
            else if(perc >= 50 && perc < 60)
            {
                Console.WriteLine("Grade is D");
            }
            else if(perc < 50)
            {
                Console.WriteLine("Grade is F");
            }
            else
            {
                Console.WriteLine("wrong entity");
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Id={id} \nName={name} \nM1 Marks={m1} \nM2 Marks={m2} \nM3 Marks={m3} \n Percentage={perc}" );
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.AcceptStudDeatils(1, "snehal", 23, 23, 23);
            s.CalculatePercentage();
            s.Grade();
        }
    }
}
