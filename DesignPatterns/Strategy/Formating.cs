namespace DesignPatterns.Strategy
{
    public interface IFormatingStrategy<Tin, Tout>
    {
        Tout Format(Tin values);
    }

    public class UserFormatingStrategy : IFormatingStrategy<List<User>, List<UserDetails>>
    {
        public List<UserDetails> Format(List<User> values)
        {
            return new List<UserDetails>();
        }
    }

    public class DeviceFormatingStrategy : IFormatingStrategy<List<Device>, List<DeviceDetails>>
    {
        public List<DeviceDetails> Format(List<Device> devices)
        {
            return new List<DeviceDetails>();
        }
    }
}
