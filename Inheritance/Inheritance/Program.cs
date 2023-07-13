using System;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            school school = new school();
            Inheritance.student Student = new Inheritance.student();
            Student.Id = 15;
            Student.Fname = "mahmoud";
            Student.Age = 21;
            Student.address = "tanta";
            Student.Class1 = 2;
            Student.school_year = 3;

            Console.WriteLine(Student.print());
            Console.WriteLine("===============================");
            Inheritance.teacher Teacher = new Inheritance.teacher();
            Teacher.Id = 15;
            Teacher.Fname = "mahmoud";
            Teacher.Age = 21;
            Teacher.Salary = 500;
            Teacher.address = "tanta";
            Teacher.Subjects1 = "arabic";
            Console.WriteLine(Teacher.print());



        }
    }

    public class school
    {
        public int id;
        public string fname;   
        public string address;
        public int age;
        

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

    }
    public class student : school
    {
        public int Class;
        public int School_year;

        public int Class1
        {
            get { return Class ; }
            set
            {
                Class = value;
            }
        }
        public int school_year
        {
            get { return School_year; }
            set { School_year = value; }
        }
        public string print()
        {
            return ($"id:{id} \nf_name:-{fname}\naddress:-{address}\nage:-{age}\nclass:-{Class}\nschool_Year:-{school_year}");
        }


    }

    public class teacher :school
    {
        public int salary;
        public string subjects;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Subjects1
        {
            get { return subjects; }
            set { subjects = value; }    
        }
        public string print()
        {
            return ($"id:{id} \nf_name:-{fname}\naddress:-{address}\nage:-{age}\nsalary:-{salary}\nsubject:-{subjects}");
        }
    }
}