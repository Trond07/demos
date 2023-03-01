using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    class Employee
    {
        // Instance variables.
        private DateTime joined;
        private string[] skills;
        private int numSkills = 0;
        private UserProfile profile;

        // Constructor 1. 
        // Name only, rely on defaults for everything else.
        public Employee(string name) 
            : this(name, 
                   DateTime.Today,
                   new UserProfile(name.Replace(" ", ""), "password", "GeneralUser@CompanyDomain.com"))
        {}

        // Constructor 2. 
        // Name, date joined, and profile. Plus salary and/or numskills.
        public Employee(string name, DateTime joined, UserProfile profile, double salary = 20000, int totalSkills = 10)
        {
            this.Name = name;
            this.Salary = salary;
            this.joined = joined;
            this.skills = new string[totalSkills];
            this.profile = profile;
        }

        // Destructor.
        ~Employee()
        {
            Console.WriteLine("Employee being destructed: {0}", this);
        }
        
        // Properties.
        public string Name   { get; private set; }
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
                Console.WriteLine("Error, employee already has 10 skills.");
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
                Console.WriteLine("Error, cannot add {0} skills.", newSkills.Length);
            }
            else
            {
                foreach (string skill in newSkills)
                    AddSkill(skill);
            }
        }

        public void DisplaySkills()
        {
            Console.WriteLine("Skills for {0}:", Name);
            for (int i = 0; i < numSkills; i++)
            {
                Console.WriteLine("  {0}", skills[i]);
            }
        }

        public void ChangePassword()
        {
            Console.Write("Enter current password: ");
            string currentPassword = Console.ReadLine();

            Console.Write("Enter new password: ");
            string newPassword1 = Console.ReadLine();

            Console.Write("Confirm new password: ");
            string newPassword2 = Console.ReadLine();

            if (newPassword1 != newPassword2)
            {
                Console.WriteLine("Sorry, you did not confirm the password correctly.");
            }
            else if (!profile.ChangePassword(currentPassword, newPassword1))
            {
                Console.WriteLine("Sorry, the current password is incorrect.");
            }
            else
            {
                Console.WriteLine("Password changed successfully!");
            }
        }

        public override string ToString()
        {
            return string.Format("{0} joined {1}, salary {2:c}.\n{3}.", Name, joined.ToShortDateString(), Salary, profile);
        }
    }
}
