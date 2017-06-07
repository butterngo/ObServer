namespace ConsoleApp1
{
    using System;
    using ConsoleApp1.Observer;

    public class Email : IContent
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string EmailTo { get; set; }
        public string EmailCC { get; set; }

        public Email(string subject, string body, string emailTo, string emailCC)
        {
            Subject = subject;
            Body = body;
            EmailTo = emailTo;
            EmailCC = emailCC;
        }

        public void Update()
        {
            Console.WriteLine($"Subject: {Subject} \n Body: {Body} \n EmailTo: {EmailTo} \n EmailCC: {EmailCC}");
        }
    }
}
