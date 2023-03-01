namespace DemoMembers
{
    public class ArgumentPassingDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nArgumentPassingDemo");
            Console.WriteLine("------------------------------------------------------");

            int num1 = 10;
            int num2 = 20;

            MethodIn(num1, num2);
            Console.WriteLine("After MethodIn, num1={0}, num2={1}", num1, num2);

            MethodRef(ref num1, ref num2);
            Console.WriteLine("After MethodRef, num1={0}, num2={1}", num1, num2);

            int prod, quot;
            MethodOut(num1, num2, out prod, out quot);
            Console.WriteLine("After MethodOut, prod={0}, quot={1}", prod, quot);
        }

        public static void MethodIn(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void MethodRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void MethodOut(int x, int y, out int p, out int q)
        {
            p = x * y;
            q = x / y;
        }
    }
}