namespace DemoTypes
{
    public enum Connection
    {
        DialUp, ISDN, BroadBand, None = -1
    }

    public class EnumDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nEnumDemo");
            Console.WriteLine("------------------------------------------------------");

            Connection con = Connection.ISDN;
            Console.WriteLine("Connection:     {0}", con);
            Console.WriteLine("Integral value: {0}", (int)con);
        }
    }
}