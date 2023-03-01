using System;

namespace DemoMembers
{
    public class Product
    {
        // Declare a variable to hold the description.
        private string description;

        // Property to get and set the description.
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }


    static class SimpleScalarPropertiesDemo
    {
        public static void DoDemo()
        {
            Console.WriteLine("\nSimpleScalarPropertiesDemo");
            Console.WriteLine("------------------------------------------------------");

            // Create a Product object
            Product aProduct = new Product();

            // Use the 'set' property procedure.
            aProduct.Description = "Chef Anton's Gumbo Mix";

            // Use the 'get' property procedure.
            Console.WriteLine(aProduct.Description);
        }
    }
}
