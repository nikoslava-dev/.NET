namespace DesignPatterns.Strategy
{
    public interface IPrintingStrategy<Tin>
    {
        void Print(Tin values);
    }

    public class UserPrintingStrategy : IPrintingStrategy<List<UserDetails>>
    {
        public void Print(List<UserDetails> users)
        {
            Console.Write("Print User Details list");
        }
    }

    public class DevicePrintingStrategy : IPrintingStrategy<List<DeviceDetails>>
    {
        public void Print(List<DeviceDetails> devices)
        {
            Console.Write("Print Devices Details list");
        }
    }
}
