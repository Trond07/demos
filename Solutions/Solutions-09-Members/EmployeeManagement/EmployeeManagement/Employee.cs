namespace EmployeeManagement
{
    public class Employee
    {
        // Instance variables.
        private DateTime joined;
        private string[] skills;
        private int numSkills = 0;

        public Employee(string name, DateTime joined, double salary = 20000, int totalSkills = 10)
        {
            this.Name = name;
            this.Salary = salary;
            this.joined = joined;
            this.skills = new string[totalSkills];
        }

        // Destructor.
        ~Employee()
        {
            Console.WriteLine("Employee being destructed: {0}", this);
        }

        // Properties.
        public string Name { get; private set; }
        public double Salary { get; private set; }

        // Additional methods.
        public void PayRaise(double amount)
        {
            Salary += amount;
        }

        public void AddSkill(string skill)
        {
            if (numSkills == skills.Length)
            {
                Console.WriteLine($"Error, employee already has {skills.Length} skills.");
            }
            else
            {
                skills[numSkills++] = skill;
            }
        }

        public void AddSkills(params string[] newSkills)
        {
            if (numSkills + newSkills.Length >= skills.Length)
            {
                Console.WriteLine($"Error, cannot add {newSkills.Length} skills.");
            }
            else
            {
                foreach (string skill in newSkills)
                    AddSkill(skill);
            }
        }

        public void DisplaySkills()
        {
            Console.WriteLine($"Skills for {Name}:");
            for (int i = 0; i < numSkills; i++)
            {
                Console.WriteLine($"  {skills[i]}");
            }
        }

        public override string ToString()
        {
            return $"{Name} joined {joined.ToShortDateString()}, salary {Salary:c}";
        }
    }
}