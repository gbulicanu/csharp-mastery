using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person = Person.Parse("John");
            // person.Introduce("George");

            var customer = new Customer(1, "John");

            // var order = new Order();
            // customer.Orders.Add(order);

            // Console.WriteLine(customer.Id);
            // Console.WriteLine(customer.Name);

            var person = new Person
            {
                Name = "John"
            };
            person.Introduce("George");
        }
    }
}
