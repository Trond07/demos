namespace DemoInterfaces
{
    public class Person : IDisposable
    {
        private string name;
        private double salary;
        private bool disposed = false;

        // Constructor.
        public Person(string n, double s)
        {
            name = n;
            salary = s;
            Console.WriteLine($"In constructor for {name}, {salary}.");
        }

        // Allow explicit disposal. 
        public void Dispose()
        {
            if (!this.disposed)
            {
                // Release resources...
                Console.WriteLine($"In Dispose() for {name}, {salary}.");

                // Set a flag to deal with multiple disposals.
                this.disposed = true;

                // Suppress destructor for this object.
                GC.SuppressFinalize(this);
            }
        }

        // Destructor.
        ~Person()
        {
            Console.WriteLine($"In destructor for {name}, {salary}");
            this.Dispose();
        }
    }


    static class ObjectDisposalDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nObjectDisposalDemo");
            Console.WriteLine("------------------------------------------------------");

            DisposeExplicitly();
            DisposeWithUsing();
        }

        public static void DisposeExplicitly()
        {
            // Create objects.
            Person obj = new Person("John", 50000);

            Console.WriteLine("Sleeping for 3 seconds...");
            Thread.Sleep(TimeSpan.FromSeconds(3));

            // Explicitly dispose an object
            Console.WriteLine("Calling Dispose() on John.");
            obj.Dispose();
        }

        public static void DisposeWithUsing()
        {
            Console.WriteLine("\nAbout to enter a using block.");

            // Declare a variable in a 'using' clause.
            using (Person obj = new Person("Fred", 50000))
            {
                Console.WriteLine("Making use of Fred in using block.");

            }   // Dispose() called automatically here.

            Console.WriteLine("After using block.");
        }
    }
}