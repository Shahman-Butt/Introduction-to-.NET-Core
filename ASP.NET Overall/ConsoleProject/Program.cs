using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleProject

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a service collection
            var services = new ServiceCollection();

            // Register services for Dependency Injection
            services.AddSingleton<IPaymentProcessor, PayPalProcessor>();
            //services.AddSingleton<IPaymentProcessor, CreditCardProcessor>();
            // To use PayPal processor instead:
 
            services.AddSingleton<IOrderService, OrderService>();

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            // Resolve and use the OrderService
            var orderService = serviceProvider.GetService<IOrderService>();
            orderService.PlaceOrder("Laptop", 1000.00m);

            // Dispose of the service provider when done
            serviceProvider.Dispose();
        }
    }
}
