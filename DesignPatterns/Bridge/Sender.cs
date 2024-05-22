namespace DesignPatterns.Bridge
{
    public abstract class Sender
    {
        private IBridge _bridge;

        public Sender(IBridge bridge)
        {
            _bridge = bridge;
        }

        public void SetBridge(IBridge bridge)
        {
            _bridge = bridge;
        }

        public abstract void Send();
    }
}
