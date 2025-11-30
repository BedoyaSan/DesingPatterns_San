using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Market : ISubject
    {
        private double price;
        private List<IObserver> observers;
        public Market()
        {
            observers = new List<IObserver>();
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
            NotifyObservers();
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this.price);
            }
        }
    }
}
