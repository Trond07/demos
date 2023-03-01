using EmployeeManagement;

Console.WriteLine("Creating an employee...");
Employee emp1 = new Employee("Kari Nordmann", DateTime.Today);

Console.WriteLine($"Giving {emp1.Name} a pay raise of 1000.");
emp1.PayRaise(1000);
Console.WriteLine($"New salary is {emp1.Salary:c}");

Console.WriteLine($"Adding skills to {emp1.Name}.");
emp1.AddSkill("C# Programming");
emp1.AddSkill("JavaScript");
emp1.AddSkills("Java", "Rust", "Cobol");
emp1.DisplaySkills();

Console.WriteLine(emp1);