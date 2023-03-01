namespace DemoTypes
{
    // This code block doesn't have "nullable reference types" enabled, so all reference types could possibly be null.
    class NullableDemo
    {
        public static void DoDemo()
        {
            CSharpIsFussyAboutNull();

            UsingNullableReferences(new Employee("Andy", 10000));
            UsingNullableReferences(null);      // OK,

            UsingNonNullableReferences(new Employee("Andy", 10000));
            UsingNonNullableReferences(null);   // Compiler warning.
        }

        private static void CSharpIsFussyAboutNull()
        {
            // We've enabled nullable checks in this project (see the .csproj file).
            
            // If we declare a "regular" object reference, the compiler gives a warning if we assign null.
            Employee emp1 = null;

            // If we really want to allow a variable to be nullable, do it this way:
            Employee? emp2 = null;
        }

        private static void UsingNullableReferences(Employee? emp)
        {
            // emp could be null, so we have to be careful.
            if (emp != null)
            {
                emp.PayRise(1000);
            }

            // Alternatively we can use the safe navigation operator.
            emp?.PayRise(1000);
        }
        
        private static void UsingNonNullableReferences(Employee emp)
        {
            // emp assumed not to be null, so the following is OK.
            emp.PayRise(1000);
        } 
    }
}
