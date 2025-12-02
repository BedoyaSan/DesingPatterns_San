using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class PaymentService
    {
        private IPaymentMethod paymentMethod;
        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void Pay()
        {
            paymentMethod.ProcessPayment();
        }
    }
}
