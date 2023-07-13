namespace student_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentData studentData = new studentData();
            Console.WriteLine("enter the Ssn:-");
            string ssn = Console.ReadLine();
            Console.WriteLine("enter the name:-");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age:-");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Address:-");
            string address = Console.ReadLine();

            studentData.Intail(ssn, name, age, address);
            Console.WriteLine(studentData.Print());

        }
    }
    class studentData
    {
        string name;
        string ssn;
        int age;
        string Address;
       
        public void Intail(string Name ,string Ssn , int Age , string _Address )
        {
            name = Name;    
            ssn = Ssn;
            age = Age;
            Address = _Address;
        }

        public string Print()
        {
            return $"====================\nname==>{name} \nSsn==>{ssn} \nage==>{age} \nAddress==>{Address} ";
        }

    }
}