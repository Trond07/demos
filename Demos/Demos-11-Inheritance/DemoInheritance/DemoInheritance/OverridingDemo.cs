namespace DemoInheritance
{
    public class OverridingDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("OverridingDemo");
            Console.WriteLine("------------------------------------------------------");

            MySuperclass obj = new MySubclass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
            obj.Method5();
            obj.Method6();
        }
    }

    public abstract class MySuperclass
    {
        public abstract void Method1();

        public virtual void Method2()
        {
            Console.WriteLine("Hello from MySuperclass.Method2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("Hello from MySuperclass.Method3");
        }

        public virtual void Method4()
        {
            Console.WriteLine("Hello from MySuperclass.Method4");
        }

        public void Method5()
        {
            Console.WriteLine("Hello from MySuperclass.Method5");
        }

        public void Method6()
        {
            Console.WriteLine("Hello from MySuperclass.Method6");
        }
    }



    public class MySubclass : MySuperclass
    {
        // Must override Method1 (it's abstract in superclass).
        public override void Method1()
        {
            Console.WriteLine("Hello from MySubclass.Method1");
        }

        // Choose to override Method2 (it's virtual in superclass).
        public override void Method2()
        {
            Console.Write("Hello from MySubclass.Method2");
            Console.Write(" ...now calling superclass method: ");
            base.Method2();
        }

        // Choose to hide Method3.
        public new void Method3()
        {
            Console.WriteLine("Hello from MySubclass.Method3");
            Console.Write(" ...now calling superclass method: ");
            base.Method3();
        }

        // Choose not to override Method4 (it's virtual in superclass, so we could have overridden if we wanted to).

        // Cannot override Method5 (it's not virtual in superclass).

        // Choose to hide Method6.
        public new void Method6()
        {
            Console.WriteLine("Hello from MySubclass.Method6");
            Console.Write(" ...now calling superclass method: ");
            base.Method6();
        }
    }
}