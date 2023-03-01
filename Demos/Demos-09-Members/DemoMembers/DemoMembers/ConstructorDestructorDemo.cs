namespace DemoMembers
{
    public class Investment
    {
        private string customer;
        private int numYears;
        private double[] investments;

        public Investment(string customer, int numYears, double initialSum) 
            : this(customer, numYears)
        {
            Console.WriteLine("Inside Investment(string,int,double) constructor for {0}.", customer);
            Invest(initialSum, 0);
        }

        public Investment(string customer, int numYears, params double[] initialSums)
            : this(customer, numYears)
        {
            Console.WriteLine("Inside Investment(string,int,double[]) constructor for {0}.", customer);
            foreach (double inv in initialSums)
            {
                Invest(inv, 0);
            }
        }

        public Investment(string customer, int numYears)
        {
            Console.WriteLine("Inside Investment(string,int) constructor for {0}.", customer);
            this.customer = customer;
            this.numYears = numYears;
            this.investments = new double[numYears];
        }

        ~Investment()
        {
            Console.WriteLine("Inside ~Investment() destructor for {0}.", customer);
            Console.WriteLine("Closing investment for {0}", this);
        }

        public void Invest(double amount, int year)
        {
            if (year < numYears)
            {
                investments[year] += amount;
            }
        }

        public double CurrentValue
        {
            get
            {
                double value = 0.0;
                for (int i = 0; i < numYears; i++)
                {
                    value += investments[i];
                }
                return value;
            }
        }

        public override string ToString()
        {
            return $"{customer}, initial sum {investments[0]}, current value {CurrentValue}.";
        }
    }

    static class ConstructorDestructorDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nConstructorDestructorDemo");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Creating objects.");
            Investment inv1 = new Investment("Ola", 3, 10000.0);
            Investment inv2 = new Investment("Kari", 4, 2000, 4000, 1000);

            Console.WriteLine("Using objects.");
            inv1.Invest(100, 1);
            inv1.Invest(200, 2);
            inv1.Invest(300, 3);
            Console.WriteLine($"Investment 1: {inv1}");

            inv2.Invest(1000, 1);
            inv2.Invest(2000, 2);
            inv2.Invest(3000, 3);
            Console.WriteLine($"Investment 2: {inv2}");
        }
    }
}