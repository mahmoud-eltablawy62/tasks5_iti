using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentData studentData = new studentData();
            Console.WriteLine("enter the Ssn:-");
            studentData.Ssn = Console.ReadLine();
            Console.WriteLine("enter the name:-");
            studentData.Name = Console.ReadLine();
            Console.WriteLine("enter the age:-");
            studentData.Age = int.Parse(Console.ReadLine());



            Console.WriteLine($"name==>{studentData.Name}\nssn==>{studentData.Ssn}\nage==>{studentData.Age}");




        }
    }
    class studentData
    {
        private string ssn;
        private string name;
        private int age;
        
        
        public studentData()
        {
            ssn = "64566";
            name = "mahmoud";
            age = 50;
            
        }
        public studentData(string _ssn , string _name , int _age  )
        {
            ssn = _ssn;
            name = _name;
            age = -age; 
            
       
        }

        public string Ssn
        {
            get { return ssn; }
            set
            { 
                ssn = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
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
}