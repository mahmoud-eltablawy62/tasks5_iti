namespace student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of student");
            int n = int.Parse(Console.ReadLine());
            studentData[] studentData = new studentData[n];
            string name;
            string address; 
            string ssn;
            int age;
            for (int i = 0; i < n; i++)
            {
                studentData[i] = new studentData();
                Console.WriteLine($"enter the data of student {i + 1}");

                Console.WriteLine("enter the Ssn:-");
                studentData[i].Ssn = Console.ReadLine();

                Console.WriteLine("enter the name:-");
                studentData[i].Name = Console.ReadLine();

               

                Console.WriteLine("enter the Age:-");
                studentData[i].Age= int.Parse(Console.ReadLine());

                
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"data of sudent {i + 1}===================>");
                Console.WriteLine($"name:-{studentData[i].Name} \nage:-{studentData[i].Age} \nssn:-{studentData[i].Ssn}");
            }
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
        public studentData(string _ssn, string _name, int _age)
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