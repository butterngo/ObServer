namespace ConsoleApp1
{
    using System;

    public class SMS : IContent
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string PhoneNumber { get; set; }

        public SMS(string subject, string body, string phoneNumber)
        {
            Subject = subject;
            Body = body;
            PhoneNumber = phoneNumber;
        }

        public void Update()
        {
            Console.WriteLine($"Subject: {Subject} \n Body: {Body} \n PhoneNumber: {PhoneNumber}");
        }
    }
}
