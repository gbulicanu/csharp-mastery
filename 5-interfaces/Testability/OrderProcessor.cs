using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            this.shippingCalculator = shippingCalculator;
        }

        public void Proccess(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = this.shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}