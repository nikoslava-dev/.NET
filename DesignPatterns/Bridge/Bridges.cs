namespace DesignPatterns.Bridge
{
    public class WebService : IBridge
    {
        public void Send(string messageType)
        {
            Console.WriteLine($"Sending {messageType} using Webservice");
        }
    }

    public class APIService : IBridge
    {
        public void Send(string messageType)
        {
            Console.WriteLine($"Sending {messageType} using API");
        }
    }
}
