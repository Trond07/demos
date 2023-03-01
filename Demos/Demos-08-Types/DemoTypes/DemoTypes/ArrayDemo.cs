namespace DemoTypes
{
    public class ArrayDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nArrayDemo");
            Console.WriteLine("------------------------------------------------------");

            int[] a1 = new int[10];

            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("a1[" + i + "] is " + a1[i]);
            }

            int[] a2 = { 200, 201, 202, 203 };

            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine("a2[" + i + "] is " + a2[i]);
            }


            string[] a3 = new string[10];

            for (int i = 0; i < a3.Length; i++)
            {
                Console.WriteLine("a3[" + i + "] is " + a3[i]);
            }


            string[] a4 = { "And", "There", "He", "Goes" };

            for (int i = 0; i < a4.Length; i++)
            {
                Console.WriteLine("a4[" + i + "] is " + a4[i]);
            }
        }
    }
}