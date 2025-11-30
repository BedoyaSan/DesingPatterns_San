using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WebMarket : IObserver
    {
        private string marketName;
        public WebMarket(string marketName)
        {
            this.marketName = marketName;
        }

        public void Update(double price)
        {
            Console.WriteLine($"The current price for web {marketName} is {price}");
        }
    }
}
