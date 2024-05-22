namespace DesignPatterns.Strategy
{
    public class DevicePageProcess : PageProcess<DeviceParams, List<Device>, List<DeviceDetails>>
    {
        public DevicePageProcess() : base(
            new DeviceLoadingStrategy(),
            new DeviceFormatingStrategy(),
            new DevicePrintingStrategy())
        {
        }
    }
}
