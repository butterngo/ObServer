namespace ConsoleApp1
{
    using ConsoleApp1.Observer;

    public interface ISubject
    {
        ISubject Unsubscriber(IObserver obj);
        ISubject Subscriber(IObserver obj);
        ISubject Notify();
    }
}
