namespace DemoFeatures
{
    public class StringDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nStringDemo");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("First name? ");
            String firstName = Console.ReadLine();

            Console.Write("Last name? ");
            String lastName = Console.ReadLine();

            Console.Write("Age? ");
            int age = int.Parse(Console.ReadLine());

            String message = string.Format("{0}, {1}... you'll be {2} next birthday.",
                                            lastName.ToUpper(), firstName, age + 1);

            Console.WriteLine("Message: {0}\n", message);
        }
    }
}
