namespace DemoTypes
{
    class Employee
    {
        private string name;
        private double salary;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public void PayRise(double amount)
        {
            salary += amount;
        }

        public override string ToString()
        {
            return $"{name} earns {salary:c}";
        }
    }
}
