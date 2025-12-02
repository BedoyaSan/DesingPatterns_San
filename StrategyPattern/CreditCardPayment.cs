using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment using Credit Card");
        }
    }
}
