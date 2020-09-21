using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator shippingCalculator;

        public OrderProcessor()
        {
            this.shippingCalculator = new ShippingCalculator();
        }

        internal void Proccess(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = this.shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Now.AddDays(1)
            };
        }
    }
}