using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class OrderService : IOrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public OrderService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void PlaceOrder(string product, decimal price)
        {
            Console.WriteLine($"Placing order for product: {product}, price: {price}");
            _paymentProcessor.ProcessPayment(price);
            Console.WriteLine($"Order placed successfully!");
        }
    }
}
