
interface IEmployee
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
    public double Pay();
}

class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}

    sealed class Executive : Employee
    {
        public double Title { get; set; }
        public int Salary { get; set; }

        public Executive() : base()
        {
            Title = 0;
            Salary = 0;
        }
        public Executive(int id, string firstName, string lastName, double title, int salary)
            : base(id, firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        public override double Pay()
        {
            if (Salary > 40)
                return 40 * Title + (1.5 * ((Salary - 40) * Title));
            else
                return Title * Salary;
        }
    //I used the same overide Pay() as the example because I couldn't think of what to put.
    static void Main(string[] args)
    {
        
        Employee ashley = new Employee(5, "Ashley", "Jones");
        ashley.Pay();

       
        Executive jane = new Executive(10, "Jane", "Smith", 50, 60);
        Console.WriteLine(jane.Fullname());
        Console.WriteLine(jane.Pay());


    }
}


    
