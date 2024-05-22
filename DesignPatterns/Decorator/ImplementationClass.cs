namespace DesignPatterns.Decorator
{
    public class ImplementationClass
    {
        public void Run()
        {
            var message = new Messenger();
            Console.WriteLine(message.GetMessage());

            var extra = new ExtraMessenger();
            Console.WriteLine(extra.GetMessage());

            var full = new FullMessenger();
            Console.WriteLine(full.GetMessage());
        }
    }
}
