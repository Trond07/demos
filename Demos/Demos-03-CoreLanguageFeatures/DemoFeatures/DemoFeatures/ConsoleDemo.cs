namespace DemoFeatures
{
    public class ConsoleDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nConsoleDemo");
            Console.WriteLine("------------------------------------------------------");
            
            // Prompt user to enter a numberic string.
            Console.Write("Please enter a whole number: ");
            string strNum = Console.ReadLine();

            // Parse numeric string, extract an int.
            int num = int.Parse(strNum);

            Console.WriteLine("Number:    {0}", num);       // Raw output
            Console.WriteLine("n  format: {0:n}", num);     // Number formatting (commas)
            Console.WriteLine("d8 format: {0:d8}", num);    // Decimal number formatting
            Console.WriteLine("f4 format: {0:f4}", num);    // Fixed-point formatting
            Console.WriteLine("c  format: {0:c}", num);     // Currency
            Console.WriteLine("e  format: {0:e}", num);     // Exponential
            Console.WriteLine("x  format: {0:x}", num);     // Hexadecimal
            Console.WriteLine();  // Blank line
        }
    }
}
