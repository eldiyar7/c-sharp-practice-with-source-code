using System;

// Classes.

namespace _001_Classes
{
    // 'Customer' class is declated.
    // Inside the class body, field type of string and custom method is created.

    class Customer
    {
        public string name;

        public void GetName()
        {
            Console.WriteLine(name);
        }
    }

    class Program
    {
        static void Main()
        {
            // Instance of 'Customer' class is created.
            Customer customer_1 = new Customer();

            // New value assigned to the field 'name' of 'customer_1' object.
            customer_1.name = "John Doe";

            // New field's value logged to the screen.
            Console.WriteLine(customer_1.name);

            // Method is called on 'customer_1' instance.
            customer_1.GetName();

            // Delay.
            Console.ReadKey();
        }
    }
}
