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
                ssn = Console.ReadLine();

                Console.WriteLine("enter the name:-");
                name = Console.ReadLine();

                Console.WriteLine("enter the Address:-");
                address =Console.ReadLine();

                Console.WriteLine("enter the Age:-");
                age = int.Parse(Console.ReadLine());

                studentData[i].Intail(name, ssn, age , address );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"data of sudent {i + 1}===================>");
                Console.WriteLine(studentData[i].Print());
            }
        }
    }

    class studentData
    {
        string name;
        string ssn;
        int age;
        string Address;
        public void Intail(string Name, string Ssn, int Age, string _Address)
        {
            name = Name;
            ssn = Ssn;
            age = Age;
            Address = _Address;
        }

        public string Print()
        {
            return $"====================\nName==>{name} \nSsn==>{ssn} \nAge==>{age} \nAddress==>{Address} ";
        }


    }
}