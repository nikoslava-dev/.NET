namespace DesignPatterns.Bridge
{
    public class EmailSender : Sender
    {
        public EmailSender(IBridge bridge) : base(bridge) { }

        public override void Send()
        {
            _bridge.Send("Email");
        }
    }
}
