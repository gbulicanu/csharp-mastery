using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person = Person.Parse("John");
            // person.Introduce("George");

            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
