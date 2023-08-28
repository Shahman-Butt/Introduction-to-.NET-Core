using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    public interface IOrderService
    {
        void PlaceOrder(string product, decimal price);
    }
}
