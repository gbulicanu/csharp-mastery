using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // UsePoints();
            // UseParams();

            // var number = int.Parse("abc");
            // UseOut();
            // UseFields();

            var person = new Person();
            // person.birthdate
        }

        public static void UseFields()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            System.Console.WriteLine(customer.Orders.Count);
        }

        public static void UseOut()
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        public static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        private static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(null);
            }
            catch (Exception)
            {

                System.Console.WriteLine("And unexpected error ocurred.");
            }
        }
    }
}
