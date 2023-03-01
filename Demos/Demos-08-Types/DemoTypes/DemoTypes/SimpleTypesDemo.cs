namespace DemoTypes
{
    public class SimpleTypesDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nSimpleTypesDemo");
            Console.WriteLine("------------------------------------------------------");

            byte b = 0;
            sbyte sb = 0;

            short i16 = 0;
            ushort u16 = 0;

            int i32 = 0;
            uint u32 = 0;

            long i64 = 0;
            ulong u64 = 0;

            float f = 0.0f;
            double d = 0.0;
            decimal dec = 0.0m;

            char c = 'A';
            bool bl = false;


            Console.WriteLine("byte:    {0,-15} [{1,32}:{2,32}]", b.GetType().ToString(),
                                                                  byte.MinValue,
                                                                  byte.MaxValue);

            Console.WriteLine("sbyte:   {0,-15} [{1,32}:{2,32}]", sb.GetType().ToString(),
                                                                  sbyte.MinValue,
                                                                  sbyte.MaxValue);

            Console.WriteLine("short:   {0,-15} [{1,32}:{2,32}]", i16.GetType().ToString(),
                                                                  short.MinValue,
                                                                  short.MaxValue);

            Console.WriteLine("ushort:  {0,-15} [{1,32}:{2,32}]", u16.GetType().ToString(),
                                                                  ushort.MinValue,
                                                                  ushort.MaxValue);

            Console.WriteLine("int:     {0,-15} [{1,32}:{2,32}]", i32.GetType().ToString(),
                                                                  int.MinValue,
                                                                  int.MaxValue);

            Console.WriteLine("uint:    {0,-15} [{1,32}:{2,32}]", u32.GetType().ToString(),
                                                                  uint.MinValue,
                                                                  uint.MaxValue);

            Console.WriteLine("long:    {0,-15} [{1,32}:{2,32}]", i64.GetType().ToString(),
                                                                  long.MinValue,
                                                                  long.MaxValue);

            Console.WriteLine("ulong:   {0,-15} [{1,32}:{2,32}]", u64.GetType().ToString(),
                                                                  ulong.MinValue,
                                                                  ulong.MaxValue);

            Console.WriteLine("float:   {0,-15} [{1,32}:{2,32}]", f.GetType().ToString(),
                                                                  float.MinValue,
                                                                  float.MaxValue);

            Console.WriteLine("double:  {0,-15} [{1,32}:{2,32}]", d.GetType().ToString(),
                                                                  double.MinValue,
                                                                  double.MaxValue);

            Console.WriteLine("decimal: {0,-15} [{1,32}:{2,32}]", dec.GetType().ToString(),
                                                                  decimal.MinValue,
                                                                  decimal.MaxValue);

            Console.WriteLine("char:    {0,-15}", c.GetType().ToString());

            Console.WriteLine("bool:    {0,-15}", bl.GetType().ToString());
        }
    }
}