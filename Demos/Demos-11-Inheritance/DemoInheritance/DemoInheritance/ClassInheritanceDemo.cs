namespace DemoInheritance
{
    public class ThisClassInheritsFromObject : object
    {
        // Define members here...
    }

    public class ThisClassAlsoInheritsFromObject
    {
        // Define members here...
    }

    public abstract class MyClass1
    {
        // Define members here...
    }

    public class MyClass2 : MyClass1
    {
        // Define members here...
    }

    public sealed class MyClass3 : MyClass2
    {
        // Define members here...
    }
}