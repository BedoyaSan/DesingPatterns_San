using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DebitCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment using Debit card");
        }
    }
}
