namespace DesignPatterns.Strategy
{
    public class ImplementationClass
    {
        void Process()
        {
            UserPageProcess userProcess = new UserPageProcess();
            userProcess.StartProcess(new UserParams());

            DevicePageProcess deviceProcess = new DevicePageProcess();
            deviceProcess.StartProcess(new DeviceParams());
        }
    }
}
