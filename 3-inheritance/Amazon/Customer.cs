
using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Caluculate(this);
            Console.WriteLine("Promoted logic change.");
        }
    }
}
