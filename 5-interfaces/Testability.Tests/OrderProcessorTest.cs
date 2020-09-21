using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Testability.Tests
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_ShippedOrder_ThrowAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Proccess(order);
        }

        [TestMethod]
        public void Proccess_NotShippedOrder_ShouldSetShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Proccess(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
