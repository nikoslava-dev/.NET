namespace DesignPatterns.Strategy
{
    public interface ILoadingStrategy<Tin, Tout>
    {
        Tout Load(Tin values);
    }

    public class UserLoadingStrategy : ILoadingStrategy<UserParams, List<User>>
    {
        public List<User> Load(UserParams parameters)
        {
            return new List<User>();
        }
    }

    public class DeviceLoadingStrategy : ILoadingStrategy<DeviceParams, List<Device>>
    {
        public List<Device> Load(DeviceParams parameters)
        {
            return new List<Device>();
        }
    }
}
