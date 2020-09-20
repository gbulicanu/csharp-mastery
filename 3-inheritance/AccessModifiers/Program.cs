using System;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher() 
        {
            var rating = this.CalculateRating(true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // var rating = customer.CalculateRating();
        }
    }
}
