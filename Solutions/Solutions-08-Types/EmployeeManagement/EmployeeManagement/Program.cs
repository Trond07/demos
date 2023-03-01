using EmployeeManagement;

Console.WriteLine("Creating an employee...");
Employee emp1 = new Employee("Kari Nordmann", 38000, new DateTime(2010, 12, 3), 2);
;

Console.WriteLine("Giving {0} a pay raise of 1000.", emp1.GetName());
emp1.PayRaise(1000);
Console.WriteLine("New salary is {0:c}", emp1.GetSalary());

Console.WriteLine("Adding skills to {0}.", emp1.GetName());
emp1.AddSkill("C# Programming");
emp1.AddSkill("Web Design");
emp1.AddSkill("Skiing");
emp1.DisplaySkills();

Console.WriteLine(emp1);