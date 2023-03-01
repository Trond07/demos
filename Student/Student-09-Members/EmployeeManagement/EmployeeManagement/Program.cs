using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee...");
            Employee emp1 = new Employee("Claire Evans");

            Console.WriteLine("Giving {0} a pay raise of 1000.", emp1.Name);
            emp1.PayRaise(1000);
            Console.WriteLine("New salary is {0:c}", emp1.Salary);

            Console.WriteLine("Adding skills to {0}.", emp1.Name);
            emp1.AddSkill("C# Programming");
            emp1.AddSkill("WPF GUI Design");
            emp1.AddSkill("Agile Development");
            emp1.AddSkills("C#", "VB", "F#");
            emp1.DisplaySkills();

            Console.WriteLine(emp1);

            Console.WriteLine("\nCreating another employee...");
            Employee emp2 = new Employee("Sara Davies", new DateTime(2007, 10, 31), new UserProfile("sarad", "mypassword", "sara.davies@myisp.com"), 30000);
            emp2.ChangePassword();
            Console.WriteLine(emp2);
        }
    }
}
