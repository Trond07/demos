namespace DemoInterfaces
{
    public interface ILoggable
    {
        void Log();
    }

    public interface IConnectable
    {
        void Connect();
        void DisConnect();
    }

    public interface ITimedConnectable : IConnectable
    {
        void Timeout(long millisecs);
    }

    public class SomeOtherClass
    {
        // Whatever... :-)
    }

    public class MyClass : SomeOtherClass, ILoggable, ITimedConnectable
    {
        public void Log()
        {
            Console.WriteLine("Hello from MyClass.Log()");
        }

        public void Connect()
        {
            Console.WriteLine("Hello from MyClass.Connect()");
        }

        public void DisConnect()
        {
            Console.WriteLine("Hello from MyClass.DisConnect()");
        }

        public void Timeout(long millisecs)
        {
            Console.WriteLine("Hello from MyClass.Timeout()");
        }
    }
}