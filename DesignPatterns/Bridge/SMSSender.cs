namespace DesignPatterns.Bridge
{
    public class SMSSender : Sender
    {
        public SMSSender(IBridge bridge) : base(bridge) { }

        public override void Send()
        {
            _bridge.Send("SMS");
        }
    }
}
