using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IPaymentMethod
    {
        public void ProcessPayment();
    }
}
