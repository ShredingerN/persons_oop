class Employee : Person
{
    public Employee(string name, int age, int salary) : base(name, age)
    {
        this.Salary = salary;
    }
    public int Salary { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" зарплата: {Salary}";
    }
}