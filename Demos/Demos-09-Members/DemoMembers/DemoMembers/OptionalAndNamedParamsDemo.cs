namespace DemoMembers
{
    public class Car
    {
        private string model;
        private int topSpeed;
        private int currentSpeed = 0;
        private int currentGear = 0;

        public Car(string model, int topSpeed)
        {
            this.model = model;
            this.topSpeed = topSpeed;
        }

        public void Accelerate(int delta, bool changeGear = false)
        {
            if (changeGear)
                currentGear++;
            currentSpeed += delta;
        }

        public override string ToString()
        {
            return $"{model}, top speed: {topSpeed}, current speed: {currentSpeed}, current gear: {currentGear}";
        }
    }

    static class OptionalAndNamedParamsDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nOptionalAndNamedParametersDemo");
            Console.WriteLine("------------------------------------------------------");

            Car aCar = new Car("Mazda", 70);

            // Demonstrate optional parameters.
            aCar.Accelerate(20);
            aCar.Accelerate(20, true);

            // Demonstrate named parameters.
            aCar.Accelerate(delta: 20);
            aCar.Accelerate(delta: 20, changeGear: true);
            aCar.Accelerate(changeGear: true, delta: 20);

            Console.WriteLine($"Car details: {aCar}");
        }
    }
}
