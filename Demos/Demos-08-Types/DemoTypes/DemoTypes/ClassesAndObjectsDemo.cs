namespace DemoTypes
{
    public class ClassesAndObjectsDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nClassesAndObjectsDemo");
            Console.WriteLine("------------------------------------------------------");

            Account acc1 = new Account("Emily", 2000);
            acc1.Deposit(500);
            acc1.Withdraw(200);
            Console.WriteLine(acc1);
        }
    }

    
    public class Account
    {
        private string holder = "";
        private double balance = 0.0;

        public Account(string holder, double balance)
        {
            this.holder = holder;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"{this.holder}, £{this.balance}";
        }
    }
}