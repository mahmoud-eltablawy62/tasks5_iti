using System.Linq;

namespace student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of student");
            int n = int.Parse(Console.ReadLine());
            studentData1[] studentData = new studentData1[n];
           
            for (int i = 0; i < n; i++)
            {
                studentData[i] = new studentData1();
                Console.WriteLine($"enter the data of student {i + 1}");
                Console.WriteLine("enter the Ssn:-");
                studentData[i].Ssn = Console.ReadLine();
                Console.WriteLine("enter the name:-");
                studentData[i].Name = Console.ReadLine();
                Console.WriteLine("enter the Age:-");
                studentData[i].Age = int.Parse(Console.ReadLine());
            }
            studentData1 st = new studentData1();
            studentData1 st1 = new studentData1();
            studentData1 st2 = new studentData1();
            studentData1 st3 = new studentData1();
            studentData1 st4 = new studentData1();
            studentData1 st5 = new studentData1();
            studentData1 st6 = new studentData1();
            studentData1 st7 = new studentData1();
            studentData1 st8 = new studentData1();
            studentData1 st9 = new studentData1();
            studentData1 st10 = new studentData1();

           
        }
    }

    class studentData1
    {
        private string ssn;
        private string name;
        private int age;
        public static int counter = 0;
        public studentData1()
        {
            ssn = "64566";
            name = "mahmoud";
            age = 50;
            counter++;
            Count();
        }
        public studentData1(string _ssn, string _name, int _age)
        {
            ssn = _ssn;
            name = _name;
            age = -age;
            counter++;
            Count();

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

        public void Count()
        {
            if(counter % 10 == 0)
            {
                Console.WriteLine("ten");
            }
        }


    }
}