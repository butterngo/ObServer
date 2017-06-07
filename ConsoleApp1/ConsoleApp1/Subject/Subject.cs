namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using ConsoleApp1.Observer;

    public class Subject : ISubject
    {
        private IList<IObserver> Observers { get; set; }

        public Subject()
        {
            Observers = new List<IObserver>();
        }

        public ISubject Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
            return this;
        }

        public ISubject Subscriber(IObserver obj)
        {
            Observers.Add(obj);
            return this;
        }

        public ISubject Unsubscriber(IObserver obj)
        {
            Observers.Remove(obj);
            return this;
        }
    }
}
