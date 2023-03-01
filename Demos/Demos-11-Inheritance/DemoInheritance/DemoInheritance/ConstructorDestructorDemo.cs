namespace DemoInheritance
{
    public class ConstructorDestructorDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nConstructorDestructorDemo");
            Console.WriteLine("------------------------------------------------------");

        Console.WriteLine("Creating objects.");
        Holiday easterBreak = new Holiday("Gran Canaria");
        Holiday summerBreak = new Holiday("North America", 14);
        SkiHoliday winterBreak = new SkiHoliday("St. Anton", 10, 85.00);

        Console.WriteLine("\nDisplaying objects.");
        Console.WriteLine($"easterBreak...  {easterBreak}");
        Console.WriteLine($"summerBreak...  {summerBreak}");
        Console.WriteLine($"winterBreak...  {winterBreak}");
        }
    }

    public class Holiday
    {
        private string resort;
        private int duration;

        public Holiday(string r) : this(r, 7)
        {
            Console.WriteLine($"Holiday constructor(r)...   {this}");
        }

        public Holiday(string r, int d)
        {
            resort = r;
            duration = d;
            Console.WriteLine($"Holiday constructor(r,d)... {this}");
        }

        ~Holiday()
        {
            Console.WriteLine($"Holiday destructor...    {this}");
        }

        public override string ToString()
        {
            return $"Resort: {resort}, duration: {duration}";
        }
    }


    public class SkiHoliday : Holiday
    {
        private double medicalCover;

        public SkiHoliday(string r, int d, double m) : base(r, d)
        {
            medicalCover = m;
            Console.WriteLine($"SkiHoliday constructor...   {this}");
        }

        ~SkiHoliday()
        {
            Console.WriteLine($"SkiHoliday destructor... {this}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, cost of medical cover: {medicalCover}";
        }
    }
}