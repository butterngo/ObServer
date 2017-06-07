namespace ConsoleApp1
{
    using System;

   public class Program
    {
        static void Main(string[] args)
        {
            new Subject()
               .Subscriber(new Email("www.c-sharp.vn", "Hello i'm vu.", "ngovu.dl@gmail.com", "ngovu.dl@gmail.com"))
               .Subscriber(new SMS("sms1", "hahaha", "0938820182"))
               .Notify();
            Console.ReadKey();
        }
    }
}