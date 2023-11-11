namespace CopyThroughSerialization
{
    [Serializable]
    public class Employee : Person
    {
        public int Salary;

        public Employee()
        {
        }

        public Employee(string[] names, Address address, int salary)
            : base(names, address)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }
    }
}
