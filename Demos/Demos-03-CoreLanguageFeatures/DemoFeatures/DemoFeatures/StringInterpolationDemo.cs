namespace DemoFeatures
{
    public class StringInterpolationDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nStringInterpolationDemo");
            Console.WriteLine("------------------------------------------------------");

            string name = "John Smith";
            int age = 21;
            double salary = 10000;

            string str = $"{name} earns {salary:C} and will be {age + 1} next birthday";
            Console.WriteLine(str);
        }
    }
}
