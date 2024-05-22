namespace DesignPatterns.Strategy
{
    public class DeviceParams
    {
        public int Skip { get; set; }

        public int Top { get; set; }
    }

    public class Device
    {
        public int UUID { get; set; }
        public string Brand { get; set; }
    }

    public class DeviceDetails
    {
        public int UUID { get; set; }
        public string Model { get; set; }
    }
}
