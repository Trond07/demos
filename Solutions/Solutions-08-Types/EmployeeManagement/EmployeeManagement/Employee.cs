namespace EmployeeManagement
{
    public class Employee
    {
        // Instance variables.
        private string name;
        private double salary;
        private DateTime joined;
        private int maxskills;


        private string[] skills;
        private int numSkills = 0;

        public Employee(string name, double salary, DateTime joined, int maxSkills)
        {
            this.name = name;
            this.salary = salary;
            this.joined = joined;
            this.maxskills = maxSkills;
            skills = new string[maxSkills];

        }

        // Methods to get/set some instance variables.
        public string GetName()
        {
            return name;
        }

        public double GetSalary()
        {
            return salary;
        }

        
          
                // Additional methods.
        public void PayRaise(double amount)
        {
            salary += amount;
        }

        public void AddSkill(string skill)
        {
            if (numSkills == skills.Length)
            {
                Console.WriteLine($"Error, employee already has {maxskills} skills.");
            }
            else
            {
                skills[numSkills++] = skill;
            }
        }

        public void DisplaySkills()
        {
            Console.WriteLine("Skills for {0}:", name);
            for (int i = 0; i < numSkills; i++)
            {
                Console.WriteLine("  {0}", skills[i]);
            }
        }

        public override string ToString()
        {
            return $"{name} joined {joined.ToShortDateString()}, salary {salary:c}";
        }
    }
}