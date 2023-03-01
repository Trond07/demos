namespace DemoMembers
{
    public class VarArgsDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nVarArgsDemo");
            Console.WriteLine("------------------------------------------------------");

            DisplayThings("Fav things:", "Jayne", "Emily", "Tom", 3, ConsoleColor.Red);
            DisplayThings("Least fav things:", new object[] {"Cardiff City", ConsoleColor.Blue}); 
        }

        private static void DisplayThings(string message, params object[] things)
        {
            Console.WriteLine(message);
            foreach (object obj in things)
            {
                Console.WriteLine($"  {obj}");
            }
        }
    }
}
