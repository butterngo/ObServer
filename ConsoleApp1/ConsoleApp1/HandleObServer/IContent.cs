namespace ConsoleApp1
{
    using ConsoleApp1.Observer;

    public interface IContent : IObserver
    {
        string Subject { get; set; }
        string Body { get; set; } 
    }
}
