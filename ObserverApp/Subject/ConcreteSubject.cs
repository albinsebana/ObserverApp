using ObserverApp.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp.Subject
{
    internal class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string message;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public void SetMessage(string newMessage)
        {
            message = newMessage;
            NotifyObservers();
        }
    }

}

